﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Quaternion : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Quaternion o;
		System.Single a1;
		checkType(l,2,out a1);
		System.Single a2;
		checkType(l,3,out a2);
		System.Single a3;
		checkType(l,4,out a3);
		System.Single a4;
		checkType(l,5,out a4);
		o=new UnityEngine.Quaternion(a1,a2,a3,a4);
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single a1;
		checkType(l,2,out a1);
		System.Single a2;
		checkType(l,3,out a2);
		System.Single a3;
		checkType(l,4,out a3);
		System.Single a4;
		checkType(l,5,out a4);
		self.Set(a1,a2,a3,a4);
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ToAngleAxis(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single a1;
		UnityEngine.Vector3 a2;
		self.ToAngleAxis(out a1,out a2);
		pushValue(l,a1);
		pushValue(l,a2);
		setBack(l,self);
		return 2;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFromToRotation(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		UnityEngine.Vector3 a1;
		checkType(l,2,out a1);
		UnityEngine.Vector3 a2;
		checkType(l,3,out a2);
		self.SetFromToRotation(a1,a2);
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLookRotation(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Quaternion self;
			checkType(l,1,out self);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.SetLookRotation(a1);
			setBack(l,self);
			return 0;
		}
		else if(argc==3){
			UnityEngine.Quaternion self;
			checkType(l,1,out self);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetLookRotation(a1,a2);
			setBack(l,self);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dot_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		var ret=UnityEngine.Quaternion.Dot(a1,a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AngleAxis_s(IntPtr l) {
		System.Single a1;
		checkType(l,1,out a1);
		UnityEngine.Vector3 a2;
		checkType(l,2,out a2);
		var ret=UnityEngine.Quaternion.AngleAxis(a1,a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FromToRotation_s(IntPtr l) {
		UnityEngine.Vector3 a1;
		checkType(l,1,out a1);
		UnityEngine.Vector3 a2;
		checkType(l,2,out a2);
		var ret=UnityEngine.Quaternion.FromToRotation(a1,a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LookRotation_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Quaternion.LookRotation(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==2){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Quaternion.LookRotation(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Slerp_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		System.Single a3;
		checkType(l,3,out a3);
		var ret=UnityEngine.Quaternion.Slerp(a1,a2,a3);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		System.Single a3;
		checkType(l,3,out a3);
		var ret=UnityEngine.Quaternion.Lerp(a1,a2,a3);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RotateTowards_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		System.Single a3;
		checkType(l,3,out a3);
		var ret=UnityEngine.Quaternion.RotateTowards(a1,a2,a3);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Inverse_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		var ret=UnityEngine.Quaternion.Inverse(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Angle_s(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		var ret=UnityEngine.Quaternion.Angle(a1,a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Euler_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Quaternion.Euler(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Quaternion.Euler(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(matchType(l,argc,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Vector3))){
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
			pushValue(l,ret);
			return 1;
		}
		else if(matchType(l,argc,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Quaternion))){
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		var ret=(a1==a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		UnityEngine.Quaternion a1;
		checkType(l,1,out a1);
		UnityEngine.Quaternion a2;
		checkType(l,2,out a2);
		var ret=(a1!=a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kEpsilon(IntPtr l) {
		pushValue(l,UnityEngine.Quaternion.kEpsilon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		pushValue(l,self.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.x=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		pushValue(l,self.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.y=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		pushValue(l,self.z);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.z=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_w(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		pushValue(l,self.w);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_w(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.w=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_identity(IntPtr l) {
		pushValue(l,UnityEngine.Quaternion.identity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eulerAngles(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		pushValue(l,self.eulerAngles);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eulerAngles(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.eulerAngles=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getItem(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		int v;
		checkType(l,2,out v);
		var ret = self[v];
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setItem(IntPtr l) {
		UnityEngine.Quaternion self;
		checkType(l,1,out self);
		int v;
		checkType(l,2,out v);
		float c;
		checkType(l,3,out c);
		self[v]=c;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Quaternion");
		addMember(l,Set);
		addMember(l,ToAngleAxis);
		addMember(l,SetFromToRotation);
		addMember(l,SetLookRotation);
		addMember(l,Dot_s);
		addMember(l,AngleAxis_s);
		addMember(l,FromToRotation_s);
		addMember(l,LookRotation_s);
		addMember(l,Slerp_s);
		addMember(l,Lerp_s);
		addMember(l,RotateTowards_s);
		addMember(l,Inverse_s);
		addMember(l,Angle_s);
		addMember(l,Euler_s);
		addMember(l,op_Multiply);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"kEpsilon",get_kEpsilon,null,false);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"z",get_z,set_z,true);
		addMember(l,"w",get_w,set_w,true);
		addMember(l,"identity",get_identity,null,false);
		addMember(l,"eulerAngles",get_eulerAngles,set_eulerAngles,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Quaternion),typeof(System.ValueType));
	}
}
