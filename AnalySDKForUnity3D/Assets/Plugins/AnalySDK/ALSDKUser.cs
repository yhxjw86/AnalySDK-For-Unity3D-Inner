using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.analysdk.unity3d
{
	public class ALSDKUser
	{
		/// <summary>
		/// 创建用户.
		/// </summary>
		/// <param name="useriD">用户id</param>
		public ALSDKUser (string userId)
		{
			try
			{
				this.userId = userId;
			} 
			catch(Exception e) 
			{
				Console.WriteLine("{0} Exception caught.", e);
			}
		}


		public enum ActionType
		{
			Reg = 0,
			Login = 1,	
		}

		/// <summary>
		/// 创建用户.
		/// </summary>
		/// <param name="useriD">用户id</param>
		/// <param name="regOrLoginType">注册或登录的类型</param>
		/// <param name="regOrLoginChannel">注册或登录的频道</param>
		/// <param name="type">操作类型,登录或是注册</param>
		public ALSDKUser(string userId, string regOrLoginType, string regOrLoginChannel, ActionType type)
		{
			try
			{
				if (type == ActionType.Reg)
				{
					this.regType = regOrLoginType;
					this.regChannel = regOrLoginChannel;
				}
				else if (type == ActionType.Login)
				{
					this.loginType = regOrLoginType;
					this.loginChannel = regOrLoginChannel;
				}

				this.userId = userId;
					
			} 
			catch(Exception e) 
			{
				Console.WriteLine("{0} Exception caught.", e);
			} 
				 
		}
			
		public string userId;
		public string nickName;
		public string gender;
		public string country;
		public string province;
		public string city;
		public int age;
		public string constellation;
		public string zodiac;
		public string regType;
		public string regChannel;
		public string loginType;
		public string loginChannel;
		public string userType;
		public string addiction;
		public int money;
		public Hashtable customProperties;


		//将所有属性转换成hashtable形式，以方便与oc交互
		public Hashtable HashtableValue()
		{
			Type t = this.GetType();
			PropertyInfo[] PropertyList = t.GetProperties();

			Hashtable hash = new Hashtable ();

			foreach (PropertyInfo item in PropertyList)
			{
				string name = item.Name;

				if (name == "customProperties") 
				{
					object value = item.GetValue(this, null);
					Hashtable customProperties = (Hashtable)value;
					Hashtable jsonHash = new Hashtable ();

					foreach (System.Collections.DictionaryEntry hashObj in customProperties )
					{
						jsonHash.Add (hashObj.Key.ToString (), hashObj.Value.ToString ());
					}

					String json = MiniJSON.jsonEncode(jsonHash);
					hash.Add (name, json);
				} 
				else
				{
					object value = item.GetValue(this, null);
					hash.Add ("_" + name, value);
				}
			}

			return hash;
		}


	}
}



