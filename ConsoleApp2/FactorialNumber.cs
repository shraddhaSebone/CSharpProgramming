using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FactorialNumber
    {
        public int isfactorial(int num)
        {
            if(num == 0) 
            { 
                return 0;
            }
            int fact = 1;
            if (num >= 0)
            {
                for (int i = num; i >= 1; i--)
                    fact = fact * i;
            }
            return fact;
        }
    }
}
