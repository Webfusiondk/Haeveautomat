using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public class CardManager
    {
        public bool ValidateCard(Card card)
        {
            if (card.ExpireingDate >= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
