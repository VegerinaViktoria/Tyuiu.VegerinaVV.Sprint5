using System.IO;
using Tyuiu.VegerinaVV.Sprint5.Task2.V3.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.VegerinaVV.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vvvik\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists); 
        }
    }
}
