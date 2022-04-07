using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrimeNumber
    {
        public bool isPrime(int num)
        {
            bool flag = true;
            if (num == 0||num==1)
                flag = false;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
