namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        // Need to create constructors before doing anything
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber) { }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal Balance) : base(accountHolderName, accountNumber, Balance) { }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw >= Balance)
            {
                return Balance;
            }

            decimal newBalance = base.Withdraw(amountToWithdraw);
            
            if (newBalance < 150.00M)
            {
                decimal serviceCharge = 2.00M;
                return base.Withdraw(serviceCharge);

            }
            else
            {
                return newBalance;

            }
        }
    }
}
