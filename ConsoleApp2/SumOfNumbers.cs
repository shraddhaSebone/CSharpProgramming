using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SumOfNumbers
    {
        public int sumofnum(int n)
        {
            int sum = 0;
            for(int i = 0; i <= n; i++)
                sum=sum+i;
            return sum;

            //if (n < 0)
            //    return 0;
            //return (n * (n + 1) / 2);
        }
    }
}
