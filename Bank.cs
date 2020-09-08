using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UmlAccount
{
	public class Bank : IBank
	{
        private string _name;
        private List<IAccount> _accountList;

        public Bank()
		{
            _accountList = new List<IAccount>();
			_name = "";
		}

        public Bank(string Name)
        {
            _name = Name;
            _accountList = new List<IAccount>();
        }

        public List<IAccount> GetAccounts()
		{
			return _accountList;
		}

		public Account FindAccount(string IBAN)
		{
			foreach (Account account in _accountList)
			{
				if (IBAN == account.getIBAN())
				{
					return account;
				}
			}

			return null;
		}

		public void AddAccount(Account account)
		{
			_accountList.Add(account);
		}
    }
}