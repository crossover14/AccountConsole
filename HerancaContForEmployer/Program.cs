using HerancaContForEmployer.Entities;
using System;


namespace HerancaContForEmployer
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BuniesAccount bacc = new BuniesAccount(1002, "Maria", 0.0, 500.0);

            //UpCasting

            Account acc1 = bacc;
            Account acc2 = new BuniesAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DonwCasting
            BuniesAccount acc4 = (BuniesAccount)acc2;
            acc4.Loam(100.0);

            // BuniesAccount acc5 = (BuniesAccount)acc3;



        }



    }
}
