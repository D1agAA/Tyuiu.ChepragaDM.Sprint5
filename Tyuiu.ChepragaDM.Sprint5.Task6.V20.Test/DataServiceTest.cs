using Tyuiu.ChepragaDM.Sprint5.Task6.V20.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V20.txt");


            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
        [TestMethod]
        public void CheckLengthCount()
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V20.txt");
            var res = ds.LoadFromDataFile(path);
            var wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
