namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; } = 0;
    

        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }


        public BankAccount(string accountHolderName, string accountNumber, decimal Balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            this.Balance = Balance;
        }

        public decimal Deposit(decimal amountToDeposit)
        {
            return Balance += amountToDeposit;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }



    }
}
