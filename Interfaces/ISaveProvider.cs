using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{

	public interface ISaveProvider
	{
		void Save<T>(T dataToSave);
		T Load<T>();
	}
}