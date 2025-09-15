namespace IDED_Scripting_TDD_Proj.Source
{
    internal class Account_B : IAccount
    {
        private float balance;

        public Account_B(float balance)
        {
            this.balance = balance > 0 ? balance : 0;
        }

        public float Balance => balance;

        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                ChangeBalance(amount);
            }
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
            {
                ChangeBalance(-amount);
            }
        }

        private void ChangeBalance(float amount) =>
            balance += amount;
    }
}