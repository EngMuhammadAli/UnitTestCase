using WebApplication8.Controllers;
using Xunit.Sdk;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculation Calculation = new Calculation();
        DataController DataController = new DataController();
        [TestMethod]
        public void TestMethod1()
        {
           double data = Calculation.Add(10 , 20);
            Assert.AreEqual(20 ,data);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double data = Calculation.Add(10, 20);
            Assert.AreEqual(25, data);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double data = Calculation.Add(10, 20);
            Assert.AreEqual(30, data);
        }
        [TestMethod]
        public void TestMethod4()
        {
           IEnumerable<string> data = DataController.Get();
           
        }
    }
}