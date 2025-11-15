using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(filePath);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(filePath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, strY);
                }
            }
            return filePath;

        }
    }
}
