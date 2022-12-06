namespace ConstantsExample
{

    public class BankAccount
    {
        public readonly static string ACCOUNT_NUMBER;
        public double balance {  get => balance; private set => balance = value; }

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
