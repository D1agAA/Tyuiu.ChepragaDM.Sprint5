using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChepragaDM.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            
            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;

            if (fileE)
            {
                File.Delete(path);
            }
            
             
            
            
            
            for (int x = startValue; x <= stopValue; x++)
            {
                double f = ((Math.Sin(x) - (2 * x)) / ((3 * x) - 1)) + Math.Sin(x) - (3 * x) + 2;
                f = Math.Round(f, 2);
                string F = Convert.ToString(f);

                if (x != stopValue)
                {
                    File.AppendAllText(path, F+Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, F);
                }
            }
            return path;
            

        }
    }
}
