﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Collider o;
		o=new UnityEngine.Collider();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClosestPointOnBounds(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		UnityEngine.Vector3 a1;
		checkType(l,2,out a1);
		var ret=self.ClosestPointOnBounds(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		UnityEngine.Ray a1;
		checkValueType(l,2,out a1);
		UnityEngine.RaycastHit a2;
		System.Single a3;
		checkType(l,4,out a3);
		var ret=self.Raycast(a1,out a2,a3);
		pushValue(l,ret);
		pushValue(l,a2);
		return 2;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachedRigidbody(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.attachedRigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTrigger(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.isTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isTrigger(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.isTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contactOffset(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.contactOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contactOffset(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.contactOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		UnityEngine.PhysicMaterial v;
		checkType(l,2,out v);
		self.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		UnityEngine.PhysicMaterial v;
		checkType(l,2,out v);
		self.sharedMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
		pushValue(l,self.bounds);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collider");
		addMember(l,ClosestPointOnBounds);
		addMember(l,Raycast);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"attachedRigidbody",get_attachedRigidbody,null,true);
		addMember(l,"isTrigger",get_isTrigger,set_isTrigger,true);
		addMember(l,"contactOffset",get_contactOffset,set_contactOffset,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"sharedMaterial",get_sharedMaterial,set_sharedMaterial,true);
		addMember(l,"bounds",get_bounds,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Collider),typeof(UnityEngine.Component));
	}
}
