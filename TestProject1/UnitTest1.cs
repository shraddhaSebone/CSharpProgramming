using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
    
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrime()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Assert.AreEqual(true, primeNumber.isPrime(7));
        }
        [TestMethod]
        public void TestStringReverse()
        {
            StringReverse stringReverse = new StringReverse();
            Assert.AreEqual("ahddarhs", stringReverse.revString("shraddha"));
        }
        [TestMethod]
        public void TestTwoSum()
        {
            TwoSum twoSum = new TwoSum();
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 5;
            int[] result = {1,4};
            int[] result2 = twoSum.sumoftwo(arr, 5, target);
            CollectionAssert.AreEqual(result2 , result);
          //  Assert.AreSame(result2 , result);
           // Assert.Equals(result, result2);
            bool resBool = false;
            if(result[0] == result2[0] && result[1] == result2[1])
                 resBool = true;

            Assert.AreEqual(true, resBool);
        }
        [TestMethod]
        public void TestFactorialNumber()
        {
            FactorialNumber factorialNumber = new FactorialNumber();
            Assert.AreEqual(120, factorialNumber.isfactorial(5));
        }
        [TestMethod]
        public void TestSumOfNumbers()
        {
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            Assert.AreEqual(55, sumOfNumbers.sumofnum(10));
        }
    }
}