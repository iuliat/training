using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1Exchange
{
    public class Exchange
    {
        public int MakeChange(int amount)
        {
            int[] bills = { 50, 20, 10, 5, 1, 100 };

            // Sort the bills descending by their value
            Array.Sort(bills);
            Array.Reverse(bills);

            if(amount <= 0)
            {
                throw new Exception("Amount inserted must be > 0.");
            }


            int result = 0;
            foreach(int bill in bills)
            {
                int no_bills = amount / bill;
                amount = amount - no_bills * bill;
                result += no_bills;
            }

            return result;
        }
    }
}
