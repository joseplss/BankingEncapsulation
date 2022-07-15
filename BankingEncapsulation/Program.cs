using System;

namespace BankingEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankA = new BankAccount();

            bool cont = false;
            double input = 0;

            Console.WriteLine($"Your balance is ${bankA.GetBalance()}\nEnter how much money you want to deposit...");
            Console.Write("$");
            input = double.Parse(Console.ReadLine());
            bankA.Deposit(input);
            Console.WriteLine($"Your money has been deposited. Your balance is:\n${bankA.GetBalance()}");

            do
            {
                Console.WriteLine("Do you want to keep depositing money? Y/N");
                string userInput = Console.ReadLine();
                if(userInput.ToLower() == "y")
                {
                    cont = true;
                    Console.WriteLine("Enter how much money you want to deposit...");
                    Console.Write("$");
                    input = double.Parse(Console.ReadLine());
                    bankA.Deposit(input);
                    Console.WriteLine($"Your money has been deposited. Your balance is:\n${bankA.GetBalance()}");
                }
                else if(userInput.ToLower() == "n")
                {
                    Console.WriteLine("You decided not to deposit. Program will now close.");
                    cont = false;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input. Program will now close.");
                }
            } while (cont == true);
            
            
        }
    }
}
