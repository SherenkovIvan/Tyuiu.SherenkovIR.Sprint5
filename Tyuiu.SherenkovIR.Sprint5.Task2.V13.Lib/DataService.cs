using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task2V13
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                File.Delete(filePath);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 1 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(filePath, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, str);
                }
                str = "";
            }

            return filePath;
        }
    }
}
