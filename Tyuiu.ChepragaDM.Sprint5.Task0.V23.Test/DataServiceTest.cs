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

            string path = ds.SaveToFileTextData(x);
             
           

            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);

        }
    } 
}
