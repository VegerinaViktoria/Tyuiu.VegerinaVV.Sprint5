using System.IO;
using Tyuiu.VegerinaVV.Sprint5.Task0.V27.Lib;
namespace Tyuiu.VegerinaVV.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\vvvik\AppData\Local\Temp\OutputFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
