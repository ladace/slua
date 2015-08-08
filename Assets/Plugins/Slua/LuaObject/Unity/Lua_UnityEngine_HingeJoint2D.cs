﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HingeJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.HingeJoint2D o;
		o=new UnityEngine.HingeJoint2D();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionForce(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		System.Single a1;
		checkType(l,2,out a1);
		var ret=self.GetReactionForce(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionTorque(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		System.Single a1;
		checkType(l,2,out a1);
		var ret=self.GetReactionTorque(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMotorTorque(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		System.Single a1;
		checkType(l,2,out a1);
		var ret=self.GetMotorTorque(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		UnityEngine.JointMotor2D v;
		checkValueType(l,2,out v);
		self.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		UnityEngine.JointAngleLimits2D v;
		checkValueType(l,2,out v);
		self.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limitState(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushEnum(l,(int)self.limitState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceAngle(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.referenceAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointAngle(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.jointAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,self.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HingeJoint2D");
		addMember(l,GetReactionForce);
		addMember(l,GetReactionTorque);
		addMember(l,GetMotorTorque);
		addMember(l,"useMotor",get_useMotor,set_useMotor,true);
		addMember(l,"useLimits",get_useLimits,set_useLimits,true);
		addMember(l,"motor",get_motor,set_motor,true);
		addMember(l,"limits",get_limits,set_limits,true);
		addMember(l,"limitState",get_limitState,null,true);
		addMember(l,"referenceAngle",get_referenceAngle,null,true);
		addMember(l,"jointAngle",get_jointAngle,null,true);
		addMember(l,"jointSpeed",get_jointSpeed,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HingeJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
