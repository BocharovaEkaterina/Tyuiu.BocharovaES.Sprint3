using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BocharovaES.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries += (Math.Pow(value, startValue) + 1) * Math.Cos(startValue);
                startValue++;
            }while (startValue <= stopValue);
            return Math.Round(SumSeries,3);
        }
    }
}
