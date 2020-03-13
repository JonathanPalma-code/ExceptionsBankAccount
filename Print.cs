using System;
using ExceptionsBankAccount.Entities;
using ExceptionsBankAccount.Entities.Exceptions;

namespace ExceptionsBankAccount
{
    class Print
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account details:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withraw Limit: ");
                double withrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(id, holder, balance, withrawLimit);

                Console.Write("\nEnter amount to withraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withraw(amount);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Operation Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}"); 
            }
        }
    }
}
