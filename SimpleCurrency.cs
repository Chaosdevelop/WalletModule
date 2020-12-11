using UnityEngine;

namespace CurrencyWallet
{

	[System.Serializable]
	public sealed class SimpleCurrency : ICurrency
	{
		[SerializeField]
		uint balance;
		[SerializeField]
		string name;
		public string Name => name;

		public uint Balance {
			get {
				return balance;
			}
			set {
				balance = value;
				onBalanceChange.Invoke(balance);
			}

		}

		event System.Action<uint> onBalanceChange;


		public SimpleCurrency(string name)
		{
			this.name = name;
		}

		public void AddBallanceChangeListener(System.Action<uint> action)
		{
			onBalanceChange += action;
		}

		public void RemoveBallanceChangeListener(System.Action<uint> action)
		{
			onBalanceChange -= action;
		}
	}

}