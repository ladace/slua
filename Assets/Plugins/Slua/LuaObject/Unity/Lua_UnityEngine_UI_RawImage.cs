﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_RawImage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeSize(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		self.SetNativeSize();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		pushValue(l,self.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		pushValue(l,self.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texture(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		self.texture=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		pushValue(l,self.uvRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		UnityEngine.UI.RawImage self=(UnityEngine.UI.RawImage)checkSelf(l);
		UnityEngine.Rect v;
		checkValueType(l,2,out v);
		self.uvRect=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.RawImage");
		addMember(l,SetNativeSize);
		addMember(l,"mainTexture",get_mainTexture,null,true);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"uvRect",get_uvRect,set_uvRect,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.RawImage),typeof(UnityEngine.UI.MaskableGraphic));
	}
}
