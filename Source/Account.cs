namespace IDED_Scripting_TDD_Proj.Source
{
    internal class Account : IAccount
    {
        public float balance;

        public Account()
        {
            balance = 100;
        }

        public Account(float balance)
        {
            // ?:
            //this.balance = balance < 0 ? 0 : balance;

            if (balance < 0)
            {
                this.balance = 0;
            }
            else
            {
                this.balance = balance;
            }
        }

        public float Balance => balance;

        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
        }
    }
}