using System.IO;
using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V20.txt";

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'c' + 'c') && (line[i] != 'C' + 'c'));
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "c";
                }
            }

            return pathSaveFile;
        }
    }
}