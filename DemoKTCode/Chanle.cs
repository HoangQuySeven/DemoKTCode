using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCode
{
    public class Chanle
    {
        public bool CheckChaLe(int i)
        {
            if (i % 2 == 0)
                return false;
            return true;
        }

        public long Sum1ToN(int n) 
        {
        long Sum = 0;
            if(n < 1) return 0;
            for (int i=1; i <= n; i++)
            {
                Sum += i;
            }
            return Sum;
        }
    }
}
