using Tyuiu.VegerinaVV.Sprint5.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла.                         *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти факториал наибольшего целого числа, которое делится на 3, в       *");
        Console.WriteLine("* файле. Полученный результат вывести на консоль. У вещественных значений *");
        Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("*                                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V14.txt";

        Console.WriteLine("Данные находятся в файле " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Факториал наибольшего целого числа, которое делится на 3 = " + res);
        Console.ReadKey();
    }
}