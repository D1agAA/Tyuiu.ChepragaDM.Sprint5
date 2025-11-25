using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChepragaDM.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {

            string str = File.ReadAllText(path);
            str = str.Replace(",", "").Replace(".", "");
            int c = 0;
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 6)
                {
                    c += 1;
                }
            }
            int res = c;
            return res;
        }
    }
}
