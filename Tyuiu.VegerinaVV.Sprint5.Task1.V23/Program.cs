using Tyuiu.VegerinaVV.Sprint5.Task1.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция F(x) = cos(x) + (cos(x)) - 3x (произвести  табулирование)  *");
        Console.WriteLine("*                               -------                                   *");
        Console.WriteLine("*                               (x + 2)                                   *");
        Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку       *");
        Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0. Результат      *");
        Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль     *");
        Console.WriteLine("* в таблицу. Значения округлить до двух знаков после запятой.             *");
        Console.WriteLine("*                                                                         *");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue,stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

    }
}