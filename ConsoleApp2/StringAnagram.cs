using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StringAnagram
    {
        public bool isAnagram(String str1,String str2)
        {
            if (str1 == null || str2 == null)
            {
                return false;
            }
            char[] str1Array = str1.ToLower().ToCharArray();
            char[] str2Array = str2.ToLower().ToCharArray();
            Array.Sort(str1Array);
            Array.Sort(str2Array); 
            for (int i = 0; i < str1Array.Length; i++)
            {
                if (str1Array[i].ToString() != str2Array[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
