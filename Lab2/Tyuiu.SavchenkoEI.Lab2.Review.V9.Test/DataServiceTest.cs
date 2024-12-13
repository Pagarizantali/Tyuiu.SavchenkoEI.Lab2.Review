using Tyuiu.SavchenkoEI.Lab2.Review.V9.Lib;

namespace Tyuiu.SavchenkoEI.Lab2.Review.V9.Test
{
    public class DataServiceTest
    {
        [Test]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 4;

            double[][] true_result = [[1, 0.73], [2, -0.72], [3, -0.54], [4, -5.15]];

            double[][] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(result, true_result);
        }
    }
}