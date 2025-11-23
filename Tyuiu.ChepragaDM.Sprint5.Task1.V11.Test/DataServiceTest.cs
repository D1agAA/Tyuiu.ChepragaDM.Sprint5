using Tyuiu.ChepragaDM.Sprint5.Task1.V11.Lib;

namespace Tyuiu.ChepragaDM.Sprint5.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = -5;
            int y = 5;
            string path = ds.SaveToFileTextData(x, y);



            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
