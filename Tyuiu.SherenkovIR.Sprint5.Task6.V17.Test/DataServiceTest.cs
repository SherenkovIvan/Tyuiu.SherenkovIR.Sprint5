using Mono.Cecil;
using System.Diagnostics;
using Tyuiu.SherenkovIR.Sprint5.Task6.V17.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.SherenkovIR.Sprint5\Tyuiu.SherenkovIR.Sprint5.Task6.V17\bin\Debug\net8.0\InPutDataFileTask6V17.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod] 
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.SherenkovIR.Sprint5\Tyuiu.SherenkovIR.Sprint5.Task6.V17\bin\Debug\net8.0\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}
