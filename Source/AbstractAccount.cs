namespace IDED_Scripting_TDD_Proj.Source
{
    internal abstract class AbstractAccount : IAccount
    {
        private float balance;

        public AbstractAccount(float balance) => this.balance = balance > 0 ? balance : 0;

        public float Balance => balance;

        public virtual void Deposit(float amount)
        {
            ChangeBalance(amount);
        }

        public virtual void Withdraw(float amount)
        {
            ChangeBalance(-amount);
        }

        private void ChangeBalance(float amount)
        {
            balance += amount;
        }
    }
}