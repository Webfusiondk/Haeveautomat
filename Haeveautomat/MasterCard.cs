using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public class MasterCard : Card
    {
        public MasterCard(BankAccount account, int pinCode, string cardOwner, int cardNumber, int regNumber) : base(account, pinCode, cardOwner, cardNumber, regNumber)
        {
        }
    }
}
