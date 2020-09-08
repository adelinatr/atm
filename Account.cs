using System;

namespace UmlAccount
{
	public class Account : IAccount
	{
        private double _amount;
        protected string _iban;

        public Account()
		{
			_amount = 0.0;
            _iban = CreateIBAN();
        }

        public void Deposit(double depositSum)
		{
            _amount += depositSum;
		}

		public double GetBalance()
		{
			return _amount;
		}

		public int WithDraw(double WithDrawAmount)
		{
            if (_amount < WithDrawAmount )
			{
				Console.WriteLine("The sum is not available");
				return -1;
			}

            _amount = _amount - WithDrawAmount;
			return 0;
		}

		public string GetIBAN()
		{
			return _iban;
		}

        private string CreateIBAN()
        {
            return "TestIban";
        }
    }
}