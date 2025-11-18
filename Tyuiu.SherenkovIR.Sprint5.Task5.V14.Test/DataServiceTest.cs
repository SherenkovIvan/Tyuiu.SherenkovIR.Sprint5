using Tyuiu.SherenkovIR.Sprint5.Task5.V14.Lib;
namespace Tyuiu.SherenkovIR.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V14.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
