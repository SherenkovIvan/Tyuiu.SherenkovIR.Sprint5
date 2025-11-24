using System.IO;
using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SherenkovIR.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutDataFileTask7V11.txt");
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    line = line.Replace("Ссловарные сслова сс удвоенной ссогласной нн",
                                       "Словарные слова с удвоенной согласной нн");

                    for (int i = 0; i < line.Length; i++)
                    {
                        
                        if (line[i] != 'c' && line[i] != 'C')
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