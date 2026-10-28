using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyiu.TinkovSS.Sprint3.Task6.V20.Lib;

namespace Tyiu.TinkovSS.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCountOfDivisors()
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;

            int res = ds.GetCountOfDivisors(startValue, stopValue);

            int wait = 41;

            Assert.AreEqual(wait, res);
        }
    }
}