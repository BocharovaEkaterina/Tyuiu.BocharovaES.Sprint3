using Tyuiu.BocharovaES.Sprint3.Task0.V26.Lib;
namespace Tyuiu.BocharovaES.Sprint3.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int k = 1;
            int kl = 9;
            double wait = -15.642;
            double res = ds.GetMultiplySeries(k, kl);
            Assert.AreEqual(wait, res);
        }
    }
}
