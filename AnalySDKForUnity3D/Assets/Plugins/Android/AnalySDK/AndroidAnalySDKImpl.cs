﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace com.analysdk.unity3d
{
	#if UNITY_ANDROID
	public class AndroidAnalySDKImpl : AnalySDKImpl 
	{
		private AndroidJavaClass androidJavaClass;
		
		public override void trackEvent (string eventName, Hashtable customParams)
		{
			
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
		    String json = MiniJSON.jsonEncode(configs);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("trackEvent", eventName,json);
			}
		}

		public override void setLocation (LocationService location)
		{
			float latitude = location.lastData.latitude;
			float longitude = location.lastData.longitude;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("setLocation", latitude, longitude);
			}
		}

		public override void trackPayEvent (ALSDKPayEvent payEvent)
		{
			Hashtable hashtable = payEvent.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("trackPayEvent",json);
			}
		}

		public override void userRegister (ALSDKUser newUser)
		{
			Hashtable hashtable = newUser.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("userRegister",json);
			}
		}

		public override void userLogin (ALSDKUser loginUser)
		{
			Hashtable hashtable = loginUser.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("userLogin",json);
			}

		}

		public override void userUpdate (ALSDKUser updateUser)
		{
			Hashtable hashtable = updateUser.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("userUpdate",json);
			}

		}

		public override void roleCreate (ALSDKRole newRole)
		{
			Hashtable hashtable = newRole.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("roleCreate",json);
			}
		}

		public override void roleLogin (ALSDKRole loginRole)
		{
			Hashtable hashtable = loginRole.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("roleLogin",json);
			}
		}

		public override void roleUpdate (ALSDKRole updateRole)
		{
			Hashtable hashtable = updateRole.HashtableValue;
			androidJavaClass = new AndroidJavaClass ("com/mob/game/CoCosAPI");
			String json = MiniJSON.jsonEncode(hashtable);
			if (androidJavaClass != null) {
				androidJavaClass.CallStatic ("roleUpdate",json);
			}

		}

	}
	#endif
}


