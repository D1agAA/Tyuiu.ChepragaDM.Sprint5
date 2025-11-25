using Tyuiu.ChepragaDM.Sprint5.Task6.V20.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Чепрага Д.М. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Чтение данных из текстового файла                     *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант 20                                                              *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович  | ИБКСб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V13.txt  в котором есть     *");
        Console.WriteLine("* набор символьных данных.Найти количество слов длиной шесть символов     *");
        Console.WriteLine("* в заданной строке.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V20.txt");



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}