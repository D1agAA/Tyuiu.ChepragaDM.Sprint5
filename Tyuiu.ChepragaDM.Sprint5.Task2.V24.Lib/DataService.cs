using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChepragaDM.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileE = fileInfo.Exists;

            if (fileE)
            {
                File.Delete(path);
            }

            int str = matrix.GetUpperBound(0) + 1;
            int stb = matrix.Length / str;
            for (int i = 0; i < stb; i++)
            {
                for(int j = 0; j < stb; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    
                }
            }
            string s = "";

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    if (j != stb - 1)
                    {
                        s += matrix[i, j] + ";";
                    }
                    else
                    {
                        s += matrix[i, j];
                    }
                }
                if (i != str - 1)
                {
                    File.AppendAllText(path, s + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, s);
                }
                s = "";
            }
            return path;
        }
    }
}
