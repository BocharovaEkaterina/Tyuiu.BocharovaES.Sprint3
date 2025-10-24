using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BocharovaES.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                p *= (Math.Pow(2, i)) / (i + 1) * Math.Cos(1.8);
            }
            return Math.Round(p,3);
        }
    }
}
