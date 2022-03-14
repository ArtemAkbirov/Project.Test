using NUnit.Framework;
using System;
namespace Project.Test
{
    public class VariablesTests
    {
        [TestCase(4,2,2,0)]
        [TestCase(11,3,3,2)]
        [TestCase(5,2,2,1)]
        public void DevineAndRemainderTest(int a, int b, int expected1, int expected2)
        {
            (int, int) result = Variables.DevineAndRemainder(a, b);
            int actual = result.Item1;
            int actual2 = result.Item2;
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2, actual2);
        }
        [TestCase(4,0)]
        [TestCase(20,0)]
        [TestCase(17,0)]
        public void DevineAndRemainderTestWhenBIsEqual0(int a, int b)
        {
            Assert.Throws<Exception>(() => Variables.DevineAndRemainder(a, b));
        }
        [TestCase(5,3,-17)]
        [TestCase(3,5,20)]
        [TestCase(1,4,7)]
        public void GetSolutionTheEquationTest(double a, double b, double expected)
        {
            double actual = Variables.GetSolutionTheEquation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 0)]
        [TestCase(3, 0)]
        [TestCase(1, 0)]
        public void GetSolutionTheEquationTestWhenAIsEqualB(int a,int b)
        {
            Assert.Throws<Exception>(() => Variables.DevineAndRemainder(a, b));
        }
        [TestCase("123","456","456","123")]
        [TestCase("abc","das","das","abc")]
        [TestCase("abc"," "," ","abc")]
        public void SwapStringsTest(string a, string b, string expected1, string expected2)
        {
            Variables.SwapStrings(ref a, ref b);
            Assert.AreEqual(expected1, a);
            Assert.AreEqual(expected2, b);
        }
        [TestCase("123", "123")]
        [TestCase("abc", "abc")]
        [TestCase("a2f", "a2f")]
        public void SwapStringsTestWhenAIsEqualB(string a, string b)
        {
            Assert.Throws<Exception>(() => Variables.SwapStrings(ref a, ref b));
        }
        [TestCase(1,5,7,2)]
        [TestCase(4,8,1,-1.75)]
        [TestCase(3,2,14,4)]
        public void GetSolutionLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.GetSolutionLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,1,2)]
        [TestCase(1,0,2)]
        [TestCase(1,2,0)]
        [TestCase(0,0,0)]
        public void GetSolutionLinearEquationTestWhenAorBorCIsEqual0(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => Variables.GetSolutionLinearEquation(a,b,c));
        }
        [TestCase(1, 2, 2, 1, "Уравнение y = -1x + 3")]
        [TestCase(-1, -2, -2, -1, "Уравнение y = -1x + -3")]
        [TestCase(-1, 2, -2, 1, "Уравнение y = 1x + 1")]
        [TestCase(1, -2, 2, -1, "Уравнение y = 1x + -1")]
        public void GetSolutionStraightLineEquationTest(double y1, double y2, double x1, double x2, string expected)
        {
            string actual = Variables.GetSolutionStraightLineEquation(y1, y2, x1,x2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,2,1,1)]
        [TestCase(3,5,4,4)]
        [TestCase(1,2,0,0)]
        public void GetSolutionStraightLineEquationTestWhenx1isEqualx2(double y1, double y2, double x1, double x2)
        {
            Assert.Throws<Exception>(() => Variables.GetSolutionStraightLineEquation(y1, y2, x1, x2));
        }
        [TestCase(2, 2, 1, 2)]
        [TestCase(3, 3, 4, 5)]
        [TestCase(0, 0, 1, 0)]
        public void GetSolutionStraightLineEquationTestWheny1isEqualy2(double y1, double y2, double x1, double x2)
        {
            Assert.Throws<Exception>(() => Variables.GetSolutionStraightLineEquation(y1, y2, x1, x2));
        }
    }

}