using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public class ATM
    {
        public string InsertCard(Card card)
        {
            CardManager manger = new CardManager();
            if (card != null)
            {
                if (manger.ValidateCard(card))
                {
                    return "Card insertet";
                }
                return "Card Expired";
            }
            return "No Card Insertet";
        }

        public string WithDrawMoney(int ammount, Card card)
        {
            //Withdraw money
            if (ammount <= card.Account.Saldo)
            {
                if (ammount > 0)
                {
                    card.Account.Saldo -= ammount;
                    return ammount + " Was withdrawn from Account." + "\n" + "Current saldo: " + card.Account.Saldo;

                }
            }
            return "You dont have enough money";
        }

        public int ValidateAmmount(string ammount)
        {
            try
            {
                if (ammount != null)
                {
                    int temp = Int32.Parse(ammount);
                    return temp;

                }
                else
                    throw new ArgumentNullException();
            }
            catch (FormatException e)
            {

                throw e;
            }
        }
    }
}
