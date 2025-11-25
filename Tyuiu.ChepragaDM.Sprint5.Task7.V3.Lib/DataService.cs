using System.IO;
using System.Reflection.Metadata.Ecma335;
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

            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
              File.WriteAllText(path, "Привет, World! This моя Первая ПРограмма.");
            }

            string str = File.ReadAllText(path, Encoding.UTF8);
            StringBuilder res = new StringBuilder();

            foreach (char i in str)
            {
                if (!((i >= 'а' && i <= 'я') || (i >= 'А' && i <= 'Я') || i == 'Ё' || i == 'ё'))
                {
                    res.Append(i);
                }

                 
            }
            string outputPath = Path.Combine($"{Directory.GetCurrentDirectory()}", "OutPutDataFileTask7V3.txt"); ;
            string resultText = res.ToString();
            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return resultText;
        }
        
    }
}
       
