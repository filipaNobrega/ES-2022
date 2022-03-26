using Exercise1;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Exercise1Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void BankAccountTest_Should_Throw_ArgumentOutOfRangeException_When_InitialBalance_Is_Less_Than_Zero()
        {
            Action action = () => { var _ = new BankAccount("alpha", -50.00); };
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void MakeDepositTest_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Less_Than_Zero()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.MakeDeposit(-10, DateTime.UtcNow, "Deposit operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Amount of deposit must be positive!"));
        }

        [Test]
        public void MakeDepositTest_Should_Add_Amount_To_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.00);
            bankAccount.MakeDeposit(50.00, DateTime.UtcNow, "PizzaHut share bill");
            bankAccount.Balance.Should().Be(550.00);
        }

        [Test]
        public void MakeWithdrawalTest_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Bigger_Than_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.MakeWithdrawal(600.00, DateTime.UtcNow, "Withdrawal operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Amount of withdrawal exceeds balance!"));
        }

        [Test]
        public void MakeWithdrawalTest_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Less_Than_Zero()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.MakeWithdrawal(-10, DateTime.UtcNow, "Withdrawal operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Amount of withdrawal must be positive!"));
        }

        [Test]
        public void MakeWithdrawalTest_Should_Subtract_Amount_From_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            bankAccount.MakeWithdrawal(50.54, DateTime.UtcNow, "Electricity payment");
            bankAccount.Balance.Should().Be(450.00);
        }
    }
}