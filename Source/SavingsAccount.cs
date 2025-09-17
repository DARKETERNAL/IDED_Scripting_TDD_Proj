namespace IDED_Scripting_TDD_Proj.Source
{
    internal class SavingsAccount : AbstractAccount
    {
        public SavingsAccount(float balance) : base(balance)
        {
        }

        public override void Deposit(float amount)
        {
            if (amount > 0)
            {
                base.Deposit(amount);
            }
            else
            {
                throw new ArgumentException("Amount to deposit must be greater than 0");
            }
        }

        public override void Withdraw(float amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    base.Withdraw(amount);
                }
                else
                {
                    throw new ArgumentException("Amount to withdraw must be less than current balance");
                }
            }
            else
            {
                throw new ArgumentException("Amount to withdraw must be greater than 0");
            }

            //if (amount > 0 && Balance >= amount)
            //{
            //    base.Withdraw(amount);
            //}
            //else
            //{
            //    throw new ArgumentException("Amount to withdraw must be greater than 0 and less than current balance");
            //}
        }
    }
}