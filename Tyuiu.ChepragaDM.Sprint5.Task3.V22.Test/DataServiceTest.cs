using Tyuiu.ChepragaDM.Sprint5.Task3.V22.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task3.V22.Test
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
