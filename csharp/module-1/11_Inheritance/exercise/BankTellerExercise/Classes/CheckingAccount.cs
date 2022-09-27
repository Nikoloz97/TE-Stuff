namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        // Need to create constructors before doing anything
        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber) { }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal Balance) : base(accountHolderName, accountNumber, Balance) { }
        
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance <= -100)
            {
                return Balance;
            }
            if ( Balance < 0 && Balance > -100)
            {
                decimal overdraftFee = 10.00M;

                return base.Withdraw(amountToWithdraw + overdraftFee);
            }

            return base.Withdraw(amountToWithdraw);
        }
    }
}
