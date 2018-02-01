using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace com.analysdk.unity3d
{
	#if UNITY_ANDROID
	public class AndroidAnalySDKImpl : AnalySDKImpl 
	{
		
	public override void trackEvent (string eventName, Hashtable customParams)
	{

	}

	public override void setLocation (LocationService location)
	{
	float latitude = location.lastData.latitude;
	float longitude = location.lastData.longitude;
	}

	public override void trackPayEvent (ALSDKPayEvent payEvent)
	{

	}

	public override void userRegister (ALSDKUser newUser)
	{

	}

	public override void userLogin (ALSDKUser loginUser)
	{

	}

	public override void userUpdate (ALSDKUser updateUser)
	{

	}

	public override void roleCreate (ALSDKRole newRole)
	{

	}

	public override void roleLogin (ALSDKRole loginRole)
	{

	}

	public override void roleUpdate (ALSDKRole updateRole)
	{

	}
			

	}
	#endif
}


