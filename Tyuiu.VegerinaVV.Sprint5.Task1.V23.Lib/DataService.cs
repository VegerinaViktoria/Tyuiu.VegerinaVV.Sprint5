using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VegerinaVV.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != -2)
                {
                    y = Math.Round(Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x, 2);
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = 0;
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
               
            }
            return path;
        }
    }
}
