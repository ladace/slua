﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_AspectRatioFitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		self.SetLayoutHorizontal();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		self.SetLayoutVertical();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectMode(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		pushEnum(l,(int)self.aspectMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectMode(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		UnityEngine.UI.AspectRatioFitter.AspectMode v;
		checkEnum(l,2,out v);
		self.aspectMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		pushValue(l,self.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.aspectRatio=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.AspectRatioFitter");
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"aspectMode",get_aspectMode,set_aspectMode,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.AspectRatioFitter),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
