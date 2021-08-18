using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public static class ATM
    {
        public static string InsertCard(Card card)
        {
            if (card != null)
            {
                return "Card insertet";
            }
            return "No Card Insertet";
        }
    }
}
