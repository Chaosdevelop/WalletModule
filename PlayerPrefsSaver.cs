using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{

	[System.Serializable]
	public class PlayerPrefsSaver : ISaveProvider
	{
		[SerializeField]
		string saveKey;

		public T Load<T>()
		{
			string json = PlayerPrefs.GetString(saveKey);
			T dataToLoad = JsonUtility.FromJson<T>(json);
			return dataToLoad;
		}

		public void Save<T>(T dataToSave)
		{

			var json = JsonUtility.ToJson(dataToSave);
			PlayerPrefs.SetString(saveKey, json);
		}
	}
}