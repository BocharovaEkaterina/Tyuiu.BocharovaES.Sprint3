using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BocharovaES.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    res += ((x / j) + Math.Sin(x));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
