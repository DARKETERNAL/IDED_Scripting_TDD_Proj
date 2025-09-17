using IDED_Scripting_TDD_Proj.Source;

namespace IDED_Scripting_TDD_Proj
{
    [TestFixture]
    public class TestAbstractClass
    {
        private SavingsAccount accountS;

        [SetUp]
        public void Setup()
        {
            accountS = new SavingsAccount(0F);
        }

        [TearDown]
        public void TearDown()
        {
            accountS = null;
        }

        [TestCase(0)]
        [TestCase(-1F)]
        [TestCase(1F)]
        public void TestCreateAccount(float balance)
        {
            IAccount account = new Account(balance);

            //Assert.That(account.Balance, Is.AtLeast(0));

            if (account.Balance < 0F)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [TestCase(0)]
        [TestCase(-1F)]
        [TestCase(1F)]
        public void TestDepositAccount(float amount)
        {
            IAccount accountA = new SavingsAccount(0F);
            IAccount accountB = new SavingsAccount(10F);
            IAccount accountC = new SavingsAccount(-1);

            if (amount > 0)
            {
                Assert.DoesNotThrow(() =>
                {
                    accountA.Deposit(amount);
                    accountB.Deposit(amount);
                    accountC.Deposit(amount);
                });
            }
            else
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    accountC.Deposit(amount);
                    accountA.Deposit(amount);
                    accountB.Deposit(amount);
                });
            }
        }

        [TestCase(100, 1)]
        [TestCase(100, 100)]
        public void TestWithdrawAccount(float initialBalance, float amount)
        {
            IAccount account = new SavingsAccount(initialBalance);

            Assert.DoesNotThrow(
                    () =>
                    {
                        account.Withdraw(amount);
                    });
        }

        [TestCase(100, 0)]
        [TestCase(100, -1)]
        [TestCase(100, 101)]
        public void TestCannotWithdrawAccount(float initialBalance, float amount)
        {
            accountS.Deposit(initialBalance);

            Assert.Throws<ArgumentException>(
                    () =>
                    {
                        accountS.Withdraw(amount);
                    });
        }
    }
}