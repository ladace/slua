﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshPath : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.NavMeshPath o;
		o=new UnityEngine.NavMeshPath();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCornersNonAlloc(IntPtr l) {
		UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
		UnityEngine.Vector3[] a1;
		checkType(l,2,out a1);
		var ret=self.GetCornersNonAlloc(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearCorners(IntPtr l) {
		UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
		self.ClearCorners();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_corners(IntPtr l) {
		UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
		pushValue(l,self.corners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_status(IntPtr l) {
		UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
		pushEnum(l,(int)self.status);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshPath");
		addMember(l,GetCornersNonAlloc);
		addMember(l,ClearCorners);
		addMember(l,"corners",get_corners,null,true);
		addMember(l,"status",get_status,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshPath));
	}
}
