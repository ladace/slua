﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Outline : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		UnityEngine.UI.Outline self=(UnityEngine.UI.Outline)checkSelf(l);
		System.Collections.Generic.List<UnityEngine.UIVertex> a1;
		checkType(l,2,out a1);
		self.ModifyVertices(a1);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Outline");
		addMember(l,ModifyVertices);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Outline),typeof(UnityEngine.UI.Shadow));
	}
}
