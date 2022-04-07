using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //*******************************************   Prime Number  *******************************************************
            {
                //Console.WriteLine("Enter your Number:");
                //int Number = Convert.ToInt32(Console.ReadLine());
                //PrimeNumber primeNumber = new PrimeNumber();
                //bool num = primeNumber.isPrime(Number);
                //if (num == false)
                //{
                //    Console.WriteLine(Number + " Number is Prime");
                //}
                //else
                //{
                //    Console.WriteLine(Number + " Number is Not Prime");
                //}
            }
            //******************************************* Anagram String  *******************************************************
            {
            //    Console.WriteLine("Enter First String:");
            //    string str1 = Console.ReadLine();
            //    Console.WriteLine("Enter Second String:");
            //    string str2 = Console.ReadLine();
            //    StringAnagram anagramOrNot = new StringAnagram();
            //    bool result = anagramOrNot.isAnagram(str1, str2);
            //    if (result == true)
            //    {
            //        System.Console.WriteLine("Strings are Anagram");
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Strings are Not Anagram");
            //    }
            }

            //******************************************* Sum of n Numbers ******************************************************
            {
               // Console.WriteLine("Enter your Number:");
               // int Number = Convert.ToInt32(Console.ReadLine());
               // SumOfNumbers sumOfNumbers = new SumOfNumbers();
               //// int sum = 0;
               // Console.WriteLine($"{Number} Sum of Number is {sumOfNumbers.sumofnum(Number)}");
            }

            //******************************************* Factorial Number ******************************************************
            {
                //Console.WriteLine("Enter your Number:");
                //int Number = Convert.ToInt32(Console.ReadLine());
                //FactorialNumber factorialNumber = new FactorialNumber();
                //Console.WriteLine($"{Number} Factorial Number {factorialNumber.isfactorial(Number)}");
            }

            //*******************************************  String Reverse  ******************************************************
            {
                //Console.WriteLine("Enter String:");
                //string str = Console.ReadLine();
                //StringReverse stringReverse = new StringReverse();
                //Console.WriteLine($"{str} Reverse String is {stringReverse.revString(str)}");
            }

            //******************************************* Two sum problem  ******************************************************
            {
                Console.WriteLine("Enter the size of array:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                
                Console.WriteLine("Enter the Element of array:");
                for (int i = 0; i < n; i++)
                {
                   arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Target value is :");
                int target = Convert.ToInt32(Console.ReadLine());
 
                TwoSum sum = new TwoSum();  
                int[] result = sum.sumoftwo(arr, n,target);
                Console.WriteLine(result[0] + " " + result[1] + " = " + target); 
              //  Console.WriteLine($"{result[0]} + {result[1]} = {target}"); 
            }
        }
    }
  
}
