using Tyuiu.ChepragaDM.Sprint5.Task7.V3.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V3.txt");


            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
