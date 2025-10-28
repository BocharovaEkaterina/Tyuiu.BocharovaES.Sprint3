using Tyuiu.BocharovaES.Sprint3.Task7.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("*          sin(x)                                                         *");
        Console.WriteLine("* F(x)= ------------ -sin(x)*2 -2*x (произвести табулирование) f(x) на    *");
        Console.WriteLine("*          x+1.2                                                          *");
        Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1.Произвести проверку деления на ноль.*");
        Console.WriteLine("* При делении на ноль вернуть значение 0. Значения округлить до двух      *");
        Console.WriteLine("* знаков после запятой.                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);


        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|     X    +   f(x)   +");
        Console.WriteLine("+----------+----------+");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 5:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}