﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Particle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Particle o;
		o=new UnityEngine.Particle();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.position=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.velocity=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_energy(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.energy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_energy(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.energy=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startEnergy(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.startEnergy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startEnergy(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.startEnergy=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.size=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.rotation=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.angularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.angularVelocity=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		pushValue(l,self.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Particle self;
		checkValueType(l,1,out self);
		UnityEngine.Color v;
		checkType(l,2,out v);
		self.color=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Particle");
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"energy",get_energy,set_energy,true);
		addMember(l,"startEnergy",get_startEnergy,set_startEnergy,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity,true);
		addMember(l,"color",get_color,set_color,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Particle),typeof(System.ValueType));
	}
}
