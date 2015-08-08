﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_AnimationTriggers : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o;
		o=new UnityEngine.UI.AnimationTriggers();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,self.normalTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		string v;
		checkType(l,2,out v);
		self.normalTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,self.highlightedTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		string v;
		checkType(l,2,out v);
		self.highlightedTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,self.pressedTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		string v;
		checkType(l,2,out v);
		self.pressedTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,self.disabledTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers self=(UnityEngine.UI.AnimationTriggers)checkSelf(l);
		string v;
		checkType(l,2,out v);
		self.disabledTrigger=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.AnimationTriggers");
		addMember(l,"normalTrigger",get_normalTrigger,set_normalTrigger,true);
		addMember(l,"highlightedTrigger",get_highlightedTrigger,set_highlightedTrigger,true);
		addMember(l,"pressedTrigger",get_pressedTrigger,set_pressedTrigger,true);
		addMember(l,"disabledTrigger",get_disabledTrigger,set_disabledTrigger,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.AnimationTriggers));
	}
}
