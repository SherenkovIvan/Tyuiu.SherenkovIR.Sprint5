using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path).Trim();
            string[] strings = fileContent.Split(' ');
            double[] doubles = new double[20];
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            {
                int maxNumber = 0;
                foreach (double num in doubles)
                {
                    if (num == Math.Floor(num))
                    {
                        int intNum = (int)num;
                        if (intNum % 3 == 0 && intNum > maxNumber)
                        {
                            maxNumber = intNum;
                        }
                    }
                }

                long factorial = 1;
                for (int i = 2; i <= maxNumber; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
              
        }
    }
}
