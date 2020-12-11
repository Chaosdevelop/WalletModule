using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurrencyWallet
{

	public interface ICurrency
	{
		string Name { get; }
		uint Balance { get; set; }

		void AddBallanceChangeListener(System.Action<uint> action);
		void RemoveBallanceChangeListener(System.Action<uint> action);
	}

}