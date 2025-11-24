using Tyuiu.SherenkovIR.Sprint5.Task6.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V17.txt";

        Console.WriteLine(" Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
