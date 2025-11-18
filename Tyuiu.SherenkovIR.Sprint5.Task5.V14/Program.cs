using Tyuiu.SherenkovIR.Sprint5.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V14.txt");

        Console.WriteLine("Файл находится: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.LoadFromDataFile(path));

        Console.ReadKey();
    }