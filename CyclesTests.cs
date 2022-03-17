
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;

namespace Project.Test
{
    public class CyclesTests
    {
        [TestCase(2,2,4)]
        [TestCase(0,2,0)]
        [TestCase(3,0,1)]
        public void ExponentiationTest(int a, int b, int expected)
        {
            int actual = Cycles.Exponentiation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,-1)]
        [TestCase(2,-5)]
        [TestCase(4,-1)]
        public void ExponentiationTestWhenBLessThanZero(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.Exponentiation(a, b));
        }
        [TestCase(200,new int[] {200,400,600,800})]
        [TestCase(300,new int[] {300,600,900})]
        [TestCase(400,new int[] {400,800})]
        public void GetNumbersThatDivisibleATest(int a, int[] expected)
        {
            int[] actual = Cycles.GetNumbersThatDivisibleA(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1111)]
        [TestCase(1200)]
        [TestCase(1500)]
        public void GetNumbersThatDivisibleATestWhenAMoreThan1000(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumbersThatDivisibleA(a));
        }
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(-1000)]
        public void GetNumbersThatDivisibleATestWhenALessThan0(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumbersThatDivisibleA(a));
        }
        [TestCase(10,3)]
        [TestCase(17,4)]
        [TestCase(9,2)]
        public void FindNumberOfPositiveTest(int a, int expected)
        {
            int actual = Cycles.FindNumberOfPositive(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-100)]
        [TestCase(-1100)]
        [TestCase(-1105)]
        public void FindNumberOfPositiveTestWhenALessThan0(int a)
        {
            Assert.Throws<Exception>(() => Cycles.FindNumberOfPositive(a));
        }
        [TestCase(100,50)]
        [TestCase(1000,500)]
        [TestCase(27,9)]
        public void FindLargestDivisorTest(int a, int expected)
        {
            int actual = Cycles.FindLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void FindLargestDivisorTestWhenAEquals0(int a)
        {
            Assert.Throws<Exception>(() => Cycles.FindLargestDivisor(a));
        }
        [TestCase(4,21,42)]
        [TestCase(7,30,70)]
        [TestCase(7,7,7)]
        public void DivideSevenTest(int a, int b, int expected)
        {
            int actual = Cycles.DivideSeven(a,b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,0)]
        public void DivideSevenTestWhenAAndBEquals0(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.DivideSeven(a,b));
        }
        [TestCase(5,5)]
        [TestCase(6,8)]
        [TestCase(7,13)]
        public void FibonacciTest(int a, int expected)
        {
            int actual = Cycles.Fibonacci(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-14)]
        public void FibonacciTestWhenALess0(int a)
        {
            Assert.Throws<Exception>(() => Cycles.Fibonacci(a));
        }
        [TestCase(4,8,4)]
        [TestCase(7,7,7)]
        [TestCase(1,6,1)]
        public void EuclidTest(int a, int b, int expected)
        {
            int actual = Cycles.Euclid(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(9,1)]
        [TestCase(1,1)]
        [TestCase(8,1)]
        public void HalfDivisionTest(int cub, int expected)
        {
            int actual = Cycles.HalfDivision(cub);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(11,2)]
        [TestCase(111,3)]
        [TestCase(101,2)]
        [TestCase(801,1)]
        public void FindNumbersOddTest(int a, int expected)
        {
            int actual = Cycles.HalfDivision(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 321)]
        [TestCase(444, 444)]
        [TestCase(456, 654)]
        public void ReverseTest(int a, int expected)
        {

            int actual = Cycles.Reverse(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123,345,"Да")]
        [TestCase(123,845,"Нет")]
        [TestCase(101,104,"Да")]
        public void SameNumbersTest(int a, int b, string expected)
        {
            string actual = Cycles.SameNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
