using HerancaContForEmployer.Entities;
using System;


namespace HerancaContForEmployer
{
    class Program
    {
        static void Main(string[] args)
        {
            BuniesAccount account = new BuniesAccount( 8010, "Bob Brow", 100.0, 500.0);

            Console.WriteLine(account.Balance);


            //Somente em subclasse pode ser alterado com o "protected"!!!!!!
            //account.Balance = 200.0
        }



    }
}
