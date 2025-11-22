using System.IO;
using Tyuiu.VegerinaVV.Sprint5.Task3.V30.Lib;
namespace Tyuiu.VegerinaVV.Sprint5.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vvvik\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
