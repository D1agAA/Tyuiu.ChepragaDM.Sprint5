
using Tyuiu.ChepragaDM.Sprint5.Task4.V6.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Чепрага Д.М. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Чтение данных из текстового файла                     *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант 6                                                               *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович  | ИБКСб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V6.txt  в котором есть      *");
        Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
        Console.WriteLine("* Х в формуле. Вычислить значение по формуле (Полученное значение         *");
        Console.WriteLine("* округлить до трёх знаков после запятой) и вернуть полученный результат .*");
        Console.WriteLine("* на консоль                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask4V6.txt");



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);
        
        Console.ReadKey();
    }
}