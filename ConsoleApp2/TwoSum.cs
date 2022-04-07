using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TwoSum
    {
        public int[] sumoftwo(int[] arr, int size, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < (size - 1); i++)
            {
                for (int j = (i + 1); j < size; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        result[0] = arr[i];
                        result[1] = arr[j];
                        return result;
                    }
                }
            }
            return result;
        }
      
    }
}
