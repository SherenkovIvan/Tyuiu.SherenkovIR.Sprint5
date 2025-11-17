using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path).Trim();
            double x = double.Parse(fileContent, System.Globalization.CultureInfo.InvariantCulture);
            double res = 1.0 / Math.Sin(x) + Math.Pow(x, 2);
            return Math.Round(res, 3);
        }
    }
}
