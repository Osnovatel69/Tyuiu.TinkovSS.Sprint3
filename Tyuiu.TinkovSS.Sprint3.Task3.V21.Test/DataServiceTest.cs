using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint3.Task3.V21.Lib;

namespace Tyuiu.TinkovSS.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "f3g5ht g4j 34kg4";
            char item = 'e';

            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "fegeht gej eekge";

            Assert.AreEqual(wait, res);
        }
    }
}