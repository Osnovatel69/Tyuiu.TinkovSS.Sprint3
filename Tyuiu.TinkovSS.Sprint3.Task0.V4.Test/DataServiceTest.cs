using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint3.Task0.V4.Lib;

namespace Tyuiu.TinkovSS.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            // Значение для проверки:
            // П(k=1..7) (sin(0.1) + k) ≈ 7481.565
            double wait = 7481.565;

            Assert.AreEqual(wait, res);
        }
    }
}