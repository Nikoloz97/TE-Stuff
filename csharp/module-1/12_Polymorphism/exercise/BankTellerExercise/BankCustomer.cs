using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        public decimal Balance { get; }

        List<IAccountable> accountableList = new List<IAccountable>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {


                decimal totalBalance = 0;

                foreach (IAccountable item in accountableList)
                {
                    totalBalance += item.Balance;
                }


                if (totalBalance >= 25_000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void AddAccount (IAccountable newAccount)
        {
            accountableList.Add(newAccount);
        }

        public IAccountable[] GetAccounts ()
        {
            return accountableList.ToArray();
        }
    }
}

