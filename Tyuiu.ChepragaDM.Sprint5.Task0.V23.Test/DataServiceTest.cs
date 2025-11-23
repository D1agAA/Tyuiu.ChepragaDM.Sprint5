using System.Diagnostics;
using System.IO;
using Tyuiu.ChepragaDM.Sprint5.Task0.V23.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.ChepragaDM.Sprint5.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;

            string path1 = @"C:\Users";
            string path2 = @"D1agAAA\source\repos\Tyuiu.ChepragaDM.Sprint5\Tyuiu.ChepragaDM.Sprint5.Task0.V23\bin\Debug\net8.0\OutPutFileTask0.txt";
            string fpath = Path.Combine(path1, path2);

            FileInfo file = new FileInfo(fpath);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);

        }
    }
}
