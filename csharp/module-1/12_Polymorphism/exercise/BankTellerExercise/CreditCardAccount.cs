using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public decimal Balance { get; private set; } 

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get;}
        
        public decimal Debt { get; private set; } = 0;


        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        public decimal Pay(decimal amountToPay)
        {
            // Why was first line added here?
            Balance += amountToPay;
            Debt -= amountToPay;
            return -Debt;
        }

        public decimal Charge(decimal amountToCharge)
        {
            // Why was first line added here?
            Balance -= amountToCharge;
            Debt += amountToCharge;
            return -Debt;
        }

    }
}
