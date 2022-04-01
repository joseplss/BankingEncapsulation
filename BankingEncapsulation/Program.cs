using System;

namespace BankingEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankA = new BankAccount();
            Console.WriteLine($"Your balance is ${bankA.Balance}\nEnter how much money you want to deposit...");
            Console.Write("$");
            bankA.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Your money has been deposited. Your balance is:\n${bankA.Balance}");
        }
    }
}
