using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using com.analysdk.unity3d;

public class Demo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnGUI ()
	{

		float scale = 1.0f;

		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			scale = Screen.width / 320;
		}

		float btnWidth = 200 * scale;
		float btnHeight = 45 * scale;
		float btnTop = 20 * scale;
		GUI.skin.button.fontSize = Convert.ToInt32(16 * scale);


		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "用户注册")) 
		{
			//ALSDKUser user = new ALSDKUser ("YourUserId");


		}
		btnTop += btnHeight + 20 * scale;

		if (GUI.Button(new Rect((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight), "用户登录"))
		{

			//ALSDKUser user = new ALSDKUser ("YourUserId");
			ALSDKUser user = new ALSDKUser ("YourUserId","YourLoginType","YourLoginChannel", ALSDKUser.ActionType.Login);
			user.age = 18;
			user.nickName = "UserNickName";
			//...

			AnalySDK.userLogin (user);
		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "用户信息更新")) 
		{

		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "创建角色")) 
		{

		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "角色登录")) 
		{

		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "角色信息更新")) 
		{

		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "支付事件")) 
		{

		}

		btnTop += btnHeight + 20 * scale;

		if (GUI.Button (new Rect ((Screen.width - btnWidth) / 2, btnTop, btnWidth, btnHeight),  "任意自定义事件")) 
		{

		}

	}


}
