using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public abstract class Card
    {
        protected Card(BankAccount account, int pinCode, string cardOwner, int cardNumber, int regNumber)
        {
            ExpireingDate = DateTime.Now.AddYears(3);
            Account = account;
            PinCode = pinCode;
            CardOwner = cardOwner;
            CardNumber = cardNumber;
            RegNumber = regNumber;
        }

        public DateTime ExpireingDate { get; set; }
        public BankAccount Account { get; set; }
        public int PinCode { get; set; }
        public string CardOwner { get; set; }
        public int CardNumber { get; set; }
        public int RegNumber { get; set; }
    }
}
