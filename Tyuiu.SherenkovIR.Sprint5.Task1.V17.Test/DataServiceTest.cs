using Tyuiu.SherenkovIR.Sprint5.Task1.V17.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}
