using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    class Program
    {
        static ATM atm = new ATM();
        static void Main(string[] args)
        {
            Card card = new MasterCard(new BankAccount(2500), 2240, "Steve", 595940192, 5543);
            while (true)
            {
                Console.WriteLine(atm.InsertCard(card));
                Console.WriteLine("Insert the ammount to withdraw");
                Console.WriteLine(atm.WithDrawMoney(atm.ValidateAmmount(Console.ReadLine()), card));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
