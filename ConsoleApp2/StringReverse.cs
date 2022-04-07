using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StringReverse
    {
		public String revString(String str)
		{  
			String rev = "";

			int length = str.Length-1;

            if (length==0)
            {
                return str;
            }
            else
			{
				for (int i = length ; i >= 0; i--)
				{
					rev = rev + str[i];
				}
			}
			return rev;
		}
	}
}
