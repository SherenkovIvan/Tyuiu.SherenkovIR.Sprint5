using Tyuiu.SherenkovIR.Sprint5.Task4.V9.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.SherenkovIR.Sprint5\Tyuiu.SherenkovIR.Sprint5.Task4.V9\bin\Debug\net8.0\InPutDataFileTask4V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
    
}
