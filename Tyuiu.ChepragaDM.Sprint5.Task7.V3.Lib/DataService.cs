using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepragaDM.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string outputFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V3");

            string content = File.ReadAllText(path, Encoding.UTF8);
            StringBuilder result = new StringBuilder();
            FileInfo fileInfo = new FileInfo(outputFilePath);
            bool filee = fileInfo.Exists;

            if (filee)
            {
                File.Delete(outputFilePath);
            }


            foreach (char c in content)
            {
                
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я'))
                    continue;

                result.Append(c);
            }

            File.WriteAllText(outputFilePath, result.ToString(), Encoding.UTF8);

            return outputFilePath;
        }
    }
}


