using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlAccount
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer();

			Account account = customer.CreateAccount();
			Console.WriteLine("Initial amount " + account.GetBalance());

			double amount1 = 100.2;
			account.Deposit(amount1);
            Console.WriteLine("Deposit " + amount1);

            Console.WriteLine("Balance " + account.GetBalance());

			double withdraw_amount = 2.0;
			account.WithDraw(withdraw_amount);

            Console.WriteLine("Balance " + account.GetBalance());

            double amount2 = 12.2;
			account.Deposit(amount2);

            Console.WriteLine("Deposit " + amount2);

            Console.WriteLine("Balance " + account.GetBalance());

            Bank bank = new Bank("Bank1");

            bank.AddAccount(account);
			var foundAccount = bank.FindAccount(account.getIBAN());

			Console.WriteLine("Balance " + foundAccount.GetBalance());
		}
	}
}
