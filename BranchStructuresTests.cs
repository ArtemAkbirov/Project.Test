using NUnit.Framework;
using System;

namespace Project.Test
{
    public class BranchStructuresTests
    {
        [TestCase(1,2,-1)]
        [TestCase(2,1,3)]
        [TestCase(3,3,9)]
        [TestCase(0,0,0)]
        public void GetSolutionComprasionTest(int a, int b, int expected)
        {
            double actual = BranchStructures.GetSolutionComprasion(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,2,"Первая четверть")]
        [TestCase(-2,1,"Вторая четверть")]
        [TestCase(-2,-1,"Третья четверть")]
        [TestCase(2,-1,"Четвертая четверть")]
        public void GetQuarterTest(int x, int y, string expected)
        {
            string actual = BranchStructures.GetQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,0)]
        [TestCase(1,0)]
        [TestCase(0,1)]

        public void GetQuarterTestWhenXOrYEqualZero(int a, int b)
        {
            Assert.Throws<Exception>(() => BranchStructures.GetQuarter(a, b));
        }
        [TestCase(3,5,1,new int[] {1,3,5})]
        [TestCase(1,3,5,new int[] {1,3,5})]
        [TestCase(22,22,15,new int[] {15,22,22})]
        [TestCase(0,0,0,new int[] {0,0,0})]
        [TestCase(0,1,0,new int[] {0,0,1})]
        public void GetAscendingTest(int a, int b, int c, int[] expected)
        {
            int[] actual = BranchStructures.GetAscending(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 7, 3, new double[] { -0.5, -3 })]
        [TestCase(-2, -7, -3, new double[] { -3, -0.5 })]
        [TestCase(2, 7, 3, new double[] { -0.5, -3 })]
        [TestCase(1, 2, 1, new double[] { -1 })]
        public void SolvingTheEquationUsingTheDiscriminantTest(int a, int b, int c, double[] expected)
        {
            double[] actual = BranchStructures.SolvingTheEquationUsingTheDiscriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,4,5)]
        [TestCase(0,0,5)]
        [TestCase(0,0,0)]
        public void SolvingTheEquationUsingTheDiscriminantTestWhenAIsEqualZero(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => BranchStructures.SolvingTheEquationUsingTheDiscriminant(a, b, c));
        }
        [TestCase(4, 1, 5)]
        [TestCase(40, 0, 5)]
        [TestCase(40, 2, 5)]
        public void SolvingTheEquationUsingTheDiscriminantTestWhenDLessThanZero(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => BranchStructures.SolvingTheEquationUsingTheDiscriminant(a, b, c));
        }
        [TestCase(12, "Двенадцать")]
        [TestCase(-12, "Минус Двенадцать")]
        [TestCase(25, "Двадцать пять")]
        [TestCase(-25, "Минус Двадцать пять")]
        [TestCase(99, "Девяносто девять")]
        [TestCase(10, "Десять")]
        public void TranslateTest(int num, string expected)
        {
           string actual = BranchStructures.Translate(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(111)]
        [TestCase(-111)]
        public void TranslateTestWhenNumIsNotRange(int num)
        {
            Assert.Throws<Exception>(() => BranchStructures.Translate(num));
        }
    }
}
