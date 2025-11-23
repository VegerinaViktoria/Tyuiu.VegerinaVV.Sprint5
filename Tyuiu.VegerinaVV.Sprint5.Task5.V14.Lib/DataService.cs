using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VegerinaVV.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double max3 = 0;

            string list = File.ReadAllText(path);
            string[] numbers = list.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in numbers)
            {
                double res = Math.Round(Convert.ToDouble(str.Replace('.', ',')), 3);
                if (res % 3 == 0 && res > max3)
                {
                    max3 = res;
                }
            }
            return GetFactorial(Convert.ToInt32(max3));

        }
        private double GetFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.", nameof(n));
            }
            if (n == 0)
            {
                return 1;
            }

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
