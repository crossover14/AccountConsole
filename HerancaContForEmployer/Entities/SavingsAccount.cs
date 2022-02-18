﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaContForEmployer.Entities
{
    class SavingsAccount :Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }
    }
}