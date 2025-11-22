using Tyuiu.VegerinaVV.Sprint5.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл.     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
        Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
        Console.WriteLine("*                                                                         *");

        int[,] mtrx = new int[3, 3] { { 5, 9, 1 },
                                      { 1, 3, 9 },
                                      { 1, 2, 2 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Массив:");
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}