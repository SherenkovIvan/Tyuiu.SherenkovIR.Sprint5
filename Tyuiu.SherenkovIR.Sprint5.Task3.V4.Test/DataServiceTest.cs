using Tyuiu.SherenkovIR.Sprint5.Task3.V4.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine($"{tempPath}", "OutPutFileTask3");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
