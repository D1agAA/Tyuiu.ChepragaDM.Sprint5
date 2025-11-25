
 using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepragaDM.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            IFormatProvider f = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double y = double.Parse(x, f);

            
            double res = (1.0 / (Math.Cos(y)) + 2.2 * Math.Pow(y, 2));

            res = Math.Round(res, 3);
            
            return res;
        }
    }
}
