using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{

	[System.Serializable]
	public class SimpleWallet : IWallet
	{

		[SerializeField]
		List<SimpleCurrency> currencies = new List<SimpleCurrency>();

		public ICurrency[] AvailableCurrency => currencies.ToArray();


		public void AddNewCurrency(string currencyName)
		{
			if (currencies.Find(arg => arg.Name == currencyName) != null)
			{
				throw new System.Exception("Already containds currency with the same name");
			}
			var newCurrency = new SimpleCurrency(currencyName);
			currencies.Add(newCurrency);
		}

	}
}