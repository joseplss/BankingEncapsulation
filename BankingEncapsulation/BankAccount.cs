using System;
using System.Collections.Generic;
using System.Text;

namespace BankingEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        public void Deposit(double b)
        {
            _balance += b;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
