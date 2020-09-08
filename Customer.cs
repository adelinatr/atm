using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UmlAccount
{
	public class Customer : ICustomer
	{
		public Customer() {}

		public Account CreateAccount()
		{
			return new Account();
		}
	}
}