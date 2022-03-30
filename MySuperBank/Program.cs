using System;
using Humanizer;
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("car".Pluralize());
            Console.WriteLine("pant".Pluralize());
            Console.WriteLine("octopus".Pluralize());
            Console.WriteLine("man".Pluralize());
            Console.WriteLine("woman".Pluralize());
            Console.WriteLine(1988.ToWords());
            //console.writeline("hello world!");
            //var account = new BankAccount("kendra", 10000);
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");


            //account.MakeWithdrawal(50, DateTime.Now, "Hammok");

            //account.MakeWithdrawal(5, DateTime.Now, "tea");
            //account.MakeWithdrawal(7, DateTime.Now, "coffe");
            //account.MakeWithdrawal(120, DateTime.Now, "XBox Game");
            //account.MakeWithdrawal(4, DateTime.Now, "food");

            //account.MakeWithdrawal(3, DateTime.Now, "water");

            //Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive.


        }
    }
}
