using System;
using NUnit.Framework;

namespace BankAccount.Tests
{

    [TestFixture]
    public class Tests
    {
        private BankAccount bankAccount;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Iva",456.6)]
        [TestCase("Mimi",657.6)]
        [TestCase("Mkvjnnfjnkdkf",56.34)]
        [TestCase("Ajjfgnerlikjkjkjkjkjkjkjk",656.7)]
        [TestCase("Ajjfgnerlikjkjkjkjkjkjkj",6556.76)]
        [TestCase("Ivan", 34.56)]
        [TestCase("Pesho", 45.46)]
        [TestCase("Tisho", 87.67)]
        public void ConstructorInizialisationTest(string name, decimal amount)
        {
            bankAccount = new BankAccount(name, amount);
            Assert.AreEqual(name,bankAccount.Name);
            Assert.AreEqual(amount,bankAccount.Balance);
        }

        [Test]
        [TestCase("Iv")]
        [TestCase("Ajjfgnerlikjkjkjkjkjkjkjkj")]
        public void NamePropertyShouldntBeLess3AndMore25(string name)
        {
            Assert.Throws<ArgumentException>(
                ()=> bankAccount = new BankAccount(name, 34.66m));
        }

        [Test]
        [TestCase(-0.001)]
        [TestCase(-1.00)]
        [TestCase(-34535.5)]
        [TestCase(-545.6)]
        [TestCase(-7897.9)]
        public void BalancePropertyShouldntBeLessThan0(decimal amount)
        {
            Assert.Throws<ArgumentException>(
                () => bankAccount = new BankAccount("dfdfdf", amount));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-0.1)]
        [TestCase(-45.65)]
        [TestCase(-787.78)]
        public void DepositAmountMustBeNoneNegative(decimal amount)
        {
            decimal startAmount = 45.67m;
            bankAccount = new BankAccount("edwwf", startAmount);

            Assert.Throws<InvalidOperationException>(()=>bankAccount.Deposit(amount));
            Assert.AreEqual(startAmount,bankAccount.Balance);
        }

        [Test]
        [TestCase(0.001)]
        [TestCase(0.1)]
        [TestCase(45.65)]
        [TestCase(787.78)]
        public void DepositAmountMustBePositive(decimal amount)
        {
            decimal startAmount = 45.67m;
            bankAccount = new BankAccount("edwwf", startAmount);

            bankAccount.Deposit(amount);

            Assert.AreEqual(startAmount + amount, bankAccount.Balance);
        }

        [Test]
        [TestCase(-0.0001)]
        [TestCase(-0.1)]
        [TestCase(-45.65)]
        [TestCase(-787.78)]
        [TestCase(45.67)]
        [TestCase(46.67)]
        [TestCase(675.67)]
        public void WithDrawAmountMustntBeNegativeAndMoreThanBalance(decimal amount)
        {
            decimal startAmount = 45.67m;
            bankAccount = new BankAccount("edwwf", startAmount);

            Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(amount));
            Assert.AreEqual(startAmount, bankAccount.Balance);
        }

        [Test]
        [TestCase(0.001)]
        [TestCase(0.1)]
        [TestCase(45.65)]
        [TestCase(44.99)]
        [TestCase(23.59)]
        [TestCase(36.48)]
        public void WithDrawAmountMustBePositiveAndLessThanBalance(decimal amount)
        {
            decimal startAmount = 45.67m;
            bankAccount = new BankAccount("edwwf", startAmount);

            decimal bankDeposit = bankAccount.Withdraw(amount);
            Assert.AreEqual(amount,bankDeposit);
            Assert.AreEqual(startAmount - amount, bankAccount.Balance);
        }
    }
}