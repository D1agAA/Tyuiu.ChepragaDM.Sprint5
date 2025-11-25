using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepragaDM.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

           
            string outputDir = @"C:\DataSprint5";
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            
            string str = File.ReadAllText(path, Encoding.UTF8);
            StringBuilder res = new StringBuilder();

            foreach (char c in str)
            {
                
                if (!((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'Ё' || c == 'ё'))
                {
                    res.Append(c);
                }
            }

            
            string outputPath = Path.Combine(outputDir, "OutPutDataFileTask7V3.txt");
            string resultText = res.ToString();
            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return resultText;
        }
    }
}

