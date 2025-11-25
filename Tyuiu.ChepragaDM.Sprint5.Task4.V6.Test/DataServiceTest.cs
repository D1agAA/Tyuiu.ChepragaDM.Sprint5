using Tyuiu.ChepragaDM.Sprint5.Task4.V6.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = @"C:\Users\D1agAAA\source\repos\Tyuiu.ChepragaDM.Sprint5\Tyuiu.ChepragaDM.Sprint5.Task4.V6\bin\Debug\net8.0\InPutDataFileTask4V6.txt"; 



            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
