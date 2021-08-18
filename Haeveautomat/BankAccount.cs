using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haeveautomat
{
    public class BankAccount
    {
        public BankAccount(int saldo)
        {
            Saldo = saldo;
        }

        public int Saldo { get; set; }
    }
}
