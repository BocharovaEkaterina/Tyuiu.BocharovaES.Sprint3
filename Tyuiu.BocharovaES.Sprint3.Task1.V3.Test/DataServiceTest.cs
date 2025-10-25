using Tyuiu.BocharovaES.Sprint3.Task1.V3.Lib;
namespace Tyuiu.BocharovaES.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double wait = 24589.408;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
