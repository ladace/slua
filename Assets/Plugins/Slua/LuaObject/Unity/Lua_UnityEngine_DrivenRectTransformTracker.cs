﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DrivenRectTransformTracker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.DrivenRectTransformTracker o;
		o=new UnityEngine.DrivenRectTransformTracker();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		UnityEngine.DrivenRectTransformTracker self;
		checkValueType(l,1,out self);
		UnityEngine.Object a1;
		checkType(l,2,out a1);
		UnityEngine.RectTransform a2;
		checkType(l,3,out a2);
		UnityEngine.DrivenTransformProperties a3;
		checkEnum(l,4,out a3);
		self.Add(a1,a2,a3);
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		UnityEngine.DrivenRectTransformTracker self;
		checkValueType(l,1,out self);
		self.Clear();
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DrivenRectTransformTracker");
		addMember(l,Add);
		addMember(l,Clear);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DrivenRectTransformTracker),typeof(System.ValueType));
	}
}
