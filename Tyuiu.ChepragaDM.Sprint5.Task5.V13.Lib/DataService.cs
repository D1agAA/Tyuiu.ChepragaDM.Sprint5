using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChepragaDM.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            
            string c = File.ReadAllText(path);
            string[] numbers = c.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var v = numbers
                .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                .Where(n => n >= -1.5 && n <= 1.5)
                .ToList();

            if (v.Count == 0)
            {
                return 0;
            }
            double res = v.Average();
            return Math.Round(res, 3);
        }
    }
}
