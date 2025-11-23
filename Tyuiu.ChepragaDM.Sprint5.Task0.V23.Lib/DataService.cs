using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ChepragaDM.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask0.txt";

            double y = (1.0 + Math.Pow(x, 3)) / Math.Pow(x, 2);

            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    } 
}
