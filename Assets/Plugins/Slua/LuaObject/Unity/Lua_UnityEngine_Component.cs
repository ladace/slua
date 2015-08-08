﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Component : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Component o;
		o=new UnityEngine.Component();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(matchType(l,argc,2,typeof(string))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetComponent(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(matchType(l,argc,2,typeof(System.Type))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponent(a1);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInChildren(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		System.Type a1;
		checkType(l,2,out a1);
		var ret=self.GetComponentInChildren(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInChildren(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentsInChildren(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetComponentsInChildren(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInParent(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		System.Type a1;
		checkType(l,2,out a1);
		var ret=self.GetComponentInParent(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInParent(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentsInParent(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetComponentsInParent(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponents(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponents(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Component> a2;
			checkType(l,3,out a2);
			self.GetComponents(a1,a2);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareTag(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		System.String a1;
		checkType(l,2,out a1);
		var ret=self.CompareTag(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessageUpwards(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SendMessageUpwards(a1);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.SendMessageUpwards(a1,a2);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.SendMessageUpwards(a1,a2);
			return 0;
		}
		else if(argc==4){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.SendMessageUpwards(a1,a2,a3);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessage(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SendMessage(a1);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.SendMessage(a1,a2);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.SendMessage(a1,a2);
			return 0;
		}
		else if(argc==4){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.SendMessage(a1,a2,a3);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BroadcastMessage(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.BroadcastMessage(a1);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.BroadcastMessage(a1,a2);
			return 0;
		}
		else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.BroadcastMessage(a1,a2);
			return 0;
		}
		else if(argc==4){
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.BroadcastMessage(a1,a2,a3);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		pushValue(l,self.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		pushValue(l,self.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tag(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		pushValue(l,self.tag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tag(IntPtr l) {
		UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
		string v;
		checkType(l,2,out v);
		self.tag=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Component");
		addMember(l,GetComponent);
		addMember(l,GetComponentInChildren);
		addMember(l,GetComponentsInChildren);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponentsInParent);
		addMember(l,GetComponents);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards);
		addMember(l,SendMessage);
		addMember(l,BroadcastMessage);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"tag",get_tag,set_tag,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Component),typeof(UnityEngine.Object));
	}
}
