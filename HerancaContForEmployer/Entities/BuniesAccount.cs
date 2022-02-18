using System;

namespace HerancaContForEmployer.Entities
{
    class BuniesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BuniesAccount()
        {
        }

        public BuniesAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loam (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else Console.WriteLine("NEGADO!!!");




        }
    }
}
