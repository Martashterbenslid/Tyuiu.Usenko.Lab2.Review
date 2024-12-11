using Tyuiu.Usenko.Lab2.Review.V13.Lib;

namespace Tyuiu.Usenko.Lab2.Review.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            var ds = new DataService();
            int start = -5;
            int end = 5;
            double expected1 = 457.88;
            double expected2 = 295.06;
            double expected3 = 169.01;
            double expected4 = 80.58;
            double expected5 = double.NaN;
            double expected6 = 2;
            double expected7 = double.NaN;
            double expected8 = 80.58;
            double expected9 = 169.01;
            double expected10 = 295.06;
            double expected11 = 457.88;
            var result = ds.GetMassFunction(start, end);
            Assert.AreEqual(expected1, result[0], 0.01);
            Assert.AreEqual(expected2, result[1], 0.01);
            Assert.AreEqual(expected3, result[2], 0.01);
            Assert.AreEqual(expected4, result[3], 0.01);
            Assert.AreEqual(expected5, result[4]);
            Assert.AreEqual(expected6, result[5], 0.01);
            Assert.AreEqual(expected7, result[6]);
            Assert.AreEqual(expected8, result[7], 0.01);
            Assert.AreEqual(expected9, result[8], 0.01);
            Assert.AreEqual(expected10, result[9], 0.01);
            Assert.AreEqual(expected11, result[10], 0.01);
        }
    }
}
