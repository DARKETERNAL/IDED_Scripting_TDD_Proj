using IDED_Scripting_TDD_Proj.Source;

namespace IDED_Scripting_TDD_Proj
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateAccount()
        {
            IAccount account1 = new Account();
            Assert.That(account1.Balance == 100);

            IAccount account2 = new Account(100000);
            Assert.That(account2.Balance == 100000);

            IAccount account3 = new Account(1);
            Assert.That(account3.Balance == 1);

            IAccount account4 = new Account(0);
            Assert.That(account4.Balance == 0);

            IAccount account5 = new Account(-100);
            Assert.That(account5.Balance == 0);
        }

        [Test]
        public void TestCreateAccountB()
        {
            IAccount account_B1 = new Account_B(-100);
            Assert.That(account_B1.Balance == 0);
        }

        [Test]
        public void TestDepositAccount()
        {
            IAccount account = new Account();
            account.Deposit(50);

            Assert.That(account.Balance == 150);

            account.Deposit(-100);
            Assert.That(account.Balance == 150);
        }

        [Test]
        public void TestDepositAccountB()
        {
            IAccount account_b1 = new Account_B(100);
            account_b1.Deposit(-50);

            Assert.That(account_b1.Balance == 100);
        }

        [Test]
        public void TestWithdrawAccount()
        {
            IAccount account = new Account();
            account.Withdraw(50);

            Assert.That(account.Balance == 50);

            account.Withdraw(-50);
            Assert.That(account.Balance == 50);
        }

        [Test]
        public void TestWithdrawAccountB()
        {
            IAccount account_b1 = new Account_B(100);
            account_b1.Withdraw(-50);

            Assert.That(account_b1.Balance == 100);
        }
    }
}