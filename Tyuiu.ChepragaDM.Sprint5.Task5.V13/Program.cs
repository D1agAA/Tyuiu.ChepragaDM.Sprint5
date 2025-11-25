using Tyuiu.ChepragaDM.Sprint5.Task5.V13.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Чепрага Д.М. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Чтение данных из текстового файла                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант 13                                                              *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович  | ИБКСб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V13.txt  в котором есть      *");
        Console.WriteLine("* вещественные значения. Найти среднее значение всех чисел в файле,       *");
        Console.WriteLine("* которые находятся в промежутке от -1.5 до 1.5. Полученный результат     *");
        Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков    *");
        Console.WriteLine("* после запятой.                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V13.txt");



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}