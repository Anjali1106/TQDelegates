using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DisplayMsg();
    public class BankEventMainCls
    {
        Bank b = new Bank();

        static void Insufficientbal() {
            Console.WriteLine("Insufficient Balance");
        }

        static void Lowbal() {
            Console.WriteLine("Low Balance");
        }

        static void Zerobal() {
            Console.WriteLine("Zero Balance");
        }

        static void Main(String[] args) {
            Bank b = new Bank();
            b.Insufficientbal += new DisplayMsg(Insufficientbal);
            b.Zerobal += new DisplayMsg(Zerobal);
            b.Lowbal += new DisplayMsg(Lowbal);

            b.credit(3000);
            b.debit(5000);
         }

    }
}
