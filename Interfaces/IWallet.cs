using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{
	public interface IWallet
	{
		ICurrency[] AvailableCurrency { get; }

		void AddNewCurrency(string currencyName);

	}
}