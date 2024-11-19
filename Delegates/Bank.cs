using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

//    Create a Bank a class, with Debit & Credit method
//You can assign a default balance using constructor
//Credit method will accept the amount that needs to be added in balance
//Debit method will accept the amount that needs to be deducted from the balance.
//If amount is greater than balance raise an event → insufficient balance
//If balance is low (< 3000) raise an event low balance
//If balance is zero then raise an event zero balance.

    public class Bank
    {
        private int amount;
        private int balance;
        public Bank( int balance) { 
            this.balance    = balance;

            if (balance < 3000)
            {
                Lowbal();
            }
            else if (balance == 0) { 
                Zerobal();
            }

        }
        public Bank() { 
        
        }

        public event DisplayMsg Insufficientbal;
        public event DisplayMsg Lowbal;
        public event DisplayMsg Zerobal;


        public void debit(int amount) {
            if (amount > balance)
            {
                Insufficientbal();
            }
            else {
                balance -= amount;
                if (balance == 0)
                {
                    Zerobal();
                }
                else {
                    Lowbal();
                }
            }
        }

        public void credit(int amount) {
            balance = balance + amount;
        }
    }
}
