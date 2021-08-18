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
        [Fact]
        public void InsertCard_ShouldInsertCard()
        {
            
            string expected = "Card insertet";

            string actual = ATM.InsertCard(new MasterCard(new BankAccount(2500),2240,"Steve",595940192,5543));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertCard_FailOnNull()
        {
            string expected = "No Card Insertet";

            string actual = ATM.InsertCard(null);

            Assert.Equal(expected, actual);
            
        }
    }
}
