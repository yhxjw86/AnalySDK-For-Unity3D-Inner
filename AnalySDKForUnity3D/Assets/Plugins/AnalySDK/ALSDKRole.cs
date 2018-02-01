using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.analysdk.unity3d
{
	public class ALSDKRole
	{

		public string userId;
		public string roleId;
		public string roServer;
		public string roName;
		public string roCareer;
		public int roLevel;
		public string roVip;
		public int roRankLevel;
		public int roEnergy;
		public int roMoney;
		public int roCoin;
		public int roSource1;
		public int roSource2;
		public int roSource3;
		public int roSource4;

		public Hashtable customProperties;

		public ALSDKRole (string userId, string roleId)
		{

			try
			{
				this.userId = userId;
				this.roleId = roleId;
			}
			catch(Exception e) 
			{
				Console.WriteLine("{0} Exception caught.", e);
			}
		}

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



