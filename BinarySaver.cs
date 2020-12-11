using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{

	[System.Serializable]
	public class BinarySaver : ISaveProvider
	{
		[SerializeField]
		string fileSavePath;

		public T Load<T>()
		{
			T dataToLoad;
			System.IO.FileStream fs = new System.IO.FileStream(fileSavePath, System.IO.FileMode.Open);
			try
			{
				System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				dataToLoad = (T)formatter.Deserialize(fs);
			}
			catch (System.Runtime.Serialization.SerializationException e)
			{
				Debug.LogError("Failed to deserialize. Reason: " + e.Message);
				throw;
			}
			finally
			{
				fs.Close();
			}
			return dataToLoad;
		}

		public void Save<T>(T dataToSave)
		{
			System.IO.FileStream fs = new System.IO.FileStream(fileSavePath, System.IO.FileMode.Create);

			System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			try
			{
				formatter.Serialize(fs, dataToSave);
			}
			catch (System.Runtime.Serialization.SerializationException e)
			{
				Debug.LogError("Failed to serialize. Reason: " + e.Message);
				throw;
			}
			finally
			{
				fs.Close();
			}
		}
	}
}