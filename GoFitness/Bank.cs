using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Bank
    {
        public double Balance;
        public Bank(double balance)
        {
            this.Balance = balance;

        }
        public double MoneyInTheBank { get { return Balance; } set { Balance = value; } }

    }
}
