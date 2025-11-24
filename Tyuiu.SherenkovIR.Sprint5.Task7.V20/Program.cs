using Tyuiu.SherenkovIR.Sprint5.Task7.V20.Lib;
 class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V20.txt";
        string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V20.txt";

        Console.WriteLine("Данные находятся в файле " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
        Console.ReadKey();

    }

}