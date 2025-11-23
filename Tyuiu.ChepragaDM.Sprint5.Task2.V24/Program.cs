using Tyuiu.ChepragaDM.Sprint5.Task2.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Чепрага Д.М. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант 24                                                              *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович  | ИБКСб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
        Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
        Console.WriteLine("* вывести на консоль                                                      *");

        DataService ds = new DataService();

        int[,] matrix = new int[3, 3] { 

            { 6, 0, 6 }, 
            {-1,-8, 7 }, 
            { 5, 1, 0 } 
        };

        int str = matrix.GetUpperBound(0) + 1;
        int stb = matrix.Length / str;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Матрица: ");
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(matrix);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
