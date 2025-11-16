using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
namespace Tyuiu.SherenkovIR.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");          
            double y = Math.Log((double)(x + 1) / (x + 2));
            double result = Math.Round(y, 3);          
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result); 
            }

            return filePath;
        }
    }
}
