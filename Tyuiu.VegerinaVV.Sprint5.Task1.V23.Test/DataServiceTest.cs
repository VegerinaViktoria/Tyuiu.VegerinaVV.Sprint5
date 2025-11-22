using System.IO;
using Tyuiu.VegerinaVV.Sprint5.Task1.V23.Lib;
namespace Tyuiu.VegerinaVV.Sprint5.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vvvik\AppData\Local\Temp\OutputFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
