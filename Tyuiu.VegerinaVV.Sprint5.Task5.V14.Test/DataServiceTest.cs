using System.IO;
using Tyuiu.VegerinaVV.Sprint5.Task5.V14.Lib;
namespace Tyuiu.VegerinaVV.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
