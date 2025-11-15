using Tyuiu.SherenkovIR.Sprint5.Task2.V13.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string filePath = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(filePath);

            bool fileExist = fileInfo.Exists;
            bool wait = false;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
