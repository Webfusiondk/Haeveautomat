using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Haeveautomat;

namespace Heaveautomat.Tests
{
    public class ATMTester
    {
        ATM atm = new ATM();
        [Fact]
        public void InsertCard_ShouldInsertCard()
        {
            
            string expected = "Card insertet";

            string actual = atm.InsertCard(new MasterCard(new BankAccount(2500),2240,"Steve",595940192,5543));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertCard_FailOnNull()
        {
            string expected = "No Card Insertet";

            string actual = atm.InsertCard(null);

            Assert.Equal(expected, actual);
            
        }
        [Theory]
        [InlineData(500)]
        [InlineData(1000)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(2500)]
        public void WithdrawMoney_ShouldWithDraw(int ammount)
        {
            Card card = new MasterCard(new BankAccount(2500), 2240, "Steve", 595940192, 5543);
            string actual = atm.WithDrawMoney(ammount, card);

            string expected = ammount + " Was withdrawn from Account." + "\n" + "Current saldo: " + card.Account.Saldo;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        [InlineData(-1)]
        [InlineData(30023324)]
        public void WithdrawMoney_ShouldNotWithDraw(int ammount)
        {
            Card card = new MasterCard(new BankAccount(2500), 2240, "Steve", 595940192, 5543);
            string actual = atm.WithDrawMoney(ammount, card);

            string expected = "You dont have enough money";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("asda")]
        [InlineData("###¤")]
        [InlineData("    ")]
        [InlineData("  2  3  ")]
        public void ValidateAmmount_ShouldNotValidate(string ammount)
        {
            Assert.Throws<FormatException>(() => atm.ValidateAmmount(ammount));
        }

        [Fact]
        public void ValidateAmmount_FailOnNull()
        {
            Assert.Throws<ArgumentNullException>(() => atm.ValidateAmmount(null));
        }

        [Theory]
        [InlineData("       23423")]
        public void ValidateAmmount_WillTurnToInt(string ammount)
        {
            bool isConvertetToInt = false;
            if (atm.ValidateAmmount(ammount) > 0)
            {
                isConvertetToInt = true;
            }

            Assert.True(isConvertetToInt);
        }

        [Fact]
        public void ValidateAmmount_ShouldValidate()
        {
            
            int expected = 3233;

            int actual = atm.ValidateAmmount("3233");

            Assert.Equal(expected,actual);
        }
    }
}
