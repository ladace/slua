﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Motion : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Motion o;
		o=new UnityEngine.Motion();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageDuration(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.averageDuration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageAngularSpeed(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.averageAngularSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageSpeed(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.averageSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_apparentSpeed(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.apparentSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLooping(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.isLooping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_legacy(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.legacy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHumanMotion(IntPtr l) {
		UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
		pushValue(l,self.isHumanMotion);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Motion");
		addMember(l,"averageDuration",get_averageDuration,null,true);
		addMember(l,"averageAngularSpeed",get_averageAngularSpeed,null,true);
		addMember(l,"averageSpeed",get_averageSpeed,null,true);
		addMember(l,"apparentSpeed",get_apparentSpeed,null,true);
		addMember(l,"isLooping",get_isLooping,null,true);
		addMember(l,"legacy",get_legacy,null,true);
		addMember(l,"isHumanMotion",get_isHumanMotion,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Motion),typeof(UnityEngine.Object));
	}
}
