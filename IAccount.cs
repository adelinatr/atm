﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UmlAccount
{
    public interface IAccount
	{
		void Deposit(double depsitSum);
		double GetBalance();
		int WithDraw(double amount);
	}
}