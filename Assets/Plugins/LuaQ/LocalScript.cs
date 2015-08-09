﻿namespace LuaQ {

	using UnityEngine;
	using System;
	using System.Reflection;
	using System.Collections;
	using System.Collections.Generic;
	using SLua;
	using LuaInterface;

	[AddComponentMenu("LuaQ/Local Script")]
	public class LocalScript : LocalScriptBase {
		[System.Serializable]
		public struct Variable {
			public string name;
			public GenericValue value;
		}

		public Variable[] variables;
		[TextArea(20, 30)]
		public string code;

		private LuaState luaState;
		private LuaFunction updateFunc;
		
		static public LuaCSFunction errorCSFunc = new LuaCSFunction(errorReport);

		private void InitializeLuaState () {
			luaState = new LuaState ();
			LuaState.pcall(luaState.L, Utils.init);
		}

		void OnEnable () {
			InitializeLuaState ();
			luaState.setObject ("self", this);
			OnLoadVariables ();
			luaState.doString (code);	
			updateFunc = (LuaFunction)luaState ["update"];
		}

		void Update () {
			if (updateFunc != null)
				CallFunction (updateFunc);
		}

		public void InvokeLua (string methodName, params object[] args) {
			var func = luaState [methodName];
			if (func != null)
				CallFunction ((LuaFunction)func, args);
			else
				Debug.Log ("Cannot find method \"" + methodName + "\".");
		}

		public override void delayInvoke (string methodName, float delay) {
			StartCoroutine (DelayInvokeLuaRoutine (methodName, delay));
		}

		private IEnumerator DelayInvokeLuaRoutine (string methodName, float delay) {
			yield return new WaitForSeconds (delay);
			InvokeLua (methodName, delay);
		}

		private void OnLoadVariables () {
			foreach (var variable in variables) {
				luaState.setObject(variable.name, variable.value.GetValue());
			}
		}

		private void CallFunction (LuaFunction func, params object[] args) {
			
			if (!LuaState.get(luaState.L).isMainThread())
			{
				Debug.LogError("Can't call lua function in bg thread");
				return;
			}

			LuaObject.pushValue (luaState.L, gameObject);
			LuaDLL.lua_pushcclosure(luaState.L, errorCSFunc, 1);
			int errorFunc = LuaDLL.lua_gettop(luaState.L);

			foreach (var arg in args) {
				LuaObject.pushVar (luaState.L, arg);
			}
			func.pcall (args.Length, errorFunc);
			
			LuaDLL.lua_remove(luaState.L, errorFunc);
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		public static int errorReport(IntPtr L)
		{
			LuaDLL.lua_getglobal(L, "debug");
			LuaDLL.lua_getfield(L, -1, "traceback");
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.lua_pushnumber(L, 2);
			LuaDLL.lua_call(L, 2, 1);
			LuaDLL.lua_remove(L, -2);

			GameObject go;
			LuaObject.checkType(L,LuaDLL.lua_upvalueindex (1),out go);

			Debug.LogError(LuaDLL.lua_tostring(L, -1), go);
			LuaDLL.lua_pop(L, 1);
			return 0;
		}
	}
}