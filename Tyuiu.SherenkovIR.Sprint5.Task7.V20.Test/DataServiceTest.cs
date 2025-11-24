using Mono.Cecil;
using System.Diagnostics;
using Tyuiu.SherenkovIR.Sprint5.Task7.V20.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.SherenkovIR.Sprint5\Tyuiu.SherenkovIR.Sprint5.Task7.V20\bin\Debug\net8.0\InPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
