using Tyuiu.ChepragaDM.Sprint5.Task2.V24.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] m = {

            { 6, 0, 6 },
            {-1,-8, 7 },
            { 5, 1, 0 }
        };

            string path = ds.SaveToFileTextData(m);



            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE); 

        }
    }
}
