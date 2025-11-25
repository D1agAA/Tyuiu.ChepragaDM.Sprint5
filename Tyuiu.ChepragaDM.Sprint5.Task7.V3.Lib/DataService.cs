using System.Reflection.Metadata.Ecma335;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepragaDM.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        
        
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path, Encoding.UTF8);
            StringBuilder res = new StringBuilder();

            foreach (char i in str)
            {
                if (!((i >= 'а' && i <= 'я') || (i >= 'А' && i <= 'Я') || i == 'Ё' || i == 'ё'))
                {
                    res.Append(i);
                }

                 
            }
            string outputPath = "OutPutDataFileTask7V3.txt";
            string resultText = res.ToString();
            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return resultText;
        }
        
    }
}
       
