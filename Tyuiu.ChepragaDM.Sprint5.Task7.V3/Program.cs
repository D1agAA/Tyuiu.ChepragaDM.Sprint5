
using Tyuiu.ChepragaDM.Sprint5.Task7.V3.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Чепрага Д.М. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Чтение данных из текстового файла                     *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант 3                                                               *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович  | ИБКСб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
       
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V.txt  в котором есть       *");
        Console.WriteLine("* набор символьных данных.Удалить все русские буквы из файла. Полученный  *");
        Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V3.txt.                   *");

        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V3.txt");
        string outputFile = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V3.txt");

         
        Console.WriteLine("Файл находится: " + path); 

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.LoadDataAndSave(path);

        File.WriteAllText(outputFile, res);
        Console.WriteLine("Данные сохранены по пути: " + outputFile);

        Console.ReadKey();
    }
}