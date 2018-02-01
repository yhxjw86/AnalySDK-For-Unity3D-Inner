using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace com.analysdk.unity3d
{
	public class ALSDKPayEvent  
	{

		public double payMoney;
		public string payContent;
		public string payType;
		public string payActivity;
		public double payDiscount;
		public string discountReason;
		public Hashtable customProperties;

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


