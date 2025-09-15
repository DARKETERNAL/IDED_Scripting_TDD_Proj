namespace IDED_Scripting_TDD_Proj.Source
{
    internal interface IAccount
    {
        float Balance { get; }

        void Deposit(float amount);

        void Withdraw(float amount);
    }
}