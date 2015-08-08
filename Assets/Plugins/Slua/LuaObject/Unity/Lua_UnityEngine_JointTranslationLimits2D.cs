﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointTranslationLimits2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.JointTranslationLimits2D o;
		o=new UnityEngine.JointTranslationLimits2D();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.JointTranslationLimits2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.JointTranslationLimits2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.min=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.JointTranslationLimits2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.JointTranslationLimits2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.max=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointTranslationLimits2D");
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"max",get_max,set_max,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointTranslationLimits2D),typeof(System.ValueType));
	}
}
