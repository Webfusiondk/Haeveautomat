using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Haeveautomat;

namespace Heaveautomat.Tests
{
    public class CardManagerTester
    {
        CardManager cardManager = new CardManager();
        [Fact]
        public void ValidateCard_ExpiredateNotExpired()
        {
            Assert.True(cardManager.ValidateKort(new MasterCard(new BankAccount(2355), 2240, "Steve", 595940192, 5543)));
        }
        [Fact]
        public void ValidateCard_CardExpired()
        {
            Card card = new MasterCard(new BankAccount(2355), 2240, "Steve", 595940192, 5543);
            card.ExpireingDate = card.ExpireingDate.AddYears(-4);
            Assert.False(cardManager.ValidateKort(card));
        }
    }
}
