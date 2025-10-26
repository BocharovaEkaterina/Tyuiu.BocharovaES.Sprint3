using Tyuiu.BocharovaES.Sprint3.Task3.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Операитор цикла foreach                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4 в строке:            *");
        Console.WriteLine("* gft hggt ntg                                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        string value = "gft hggt ntg";
        char replaceable = 'g';
        char replacement = '4';
        string wait = "4ft h44t nt4";

        Console.WriteLine("искомая сточка = " + value);
        Console.WriteLine("заменяемое = " + replaceable);
        Console.WriteLine("замена = " + replacement);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("новая сточка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));
        Console.ReadKey();
    }
}