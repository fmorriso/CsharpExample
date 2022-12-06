namespace ConstantsExample
{

    public class BankAccount
    {
        public readonly static string ACCOUNT_NUMBER;
        private double balance;

        static BankAccount()
        {
            ACCOUNT_NUMBER = "ACCT000";            
        }

        public BankAccount()
        {
            balance = 0;
        }
    }
}
