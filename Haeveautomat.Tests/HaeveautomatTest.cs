using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Haeveautomat;

namespace Haeveautomat.Tests
{
    public class HaeveautomatTest
    {
        [Fact]
        public void InsertKort_ShouldInsert()
        {
            //Arrange
            string expected = "Card insertet";
            //Act
            string actual = "asdas";//Heaveautomat.InsertCard(new MasterCard(new BankAccount(2500),2240,"Steve",595940192,5543));

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
