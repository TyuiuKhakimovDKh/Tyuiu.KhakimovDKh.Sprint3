

using Tyuiu.KhakimovDKh.Sprint3.Task3.V7.Lib;


namespace Tyuiu.KhakimovDKh.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "gft hggt ntg";
            char rpb = 'g';
            char rpm = '4';

            string res = ds.ReplaceCharOnNum(str, rpb, rpm);

            string wait = "4ft h44t nt4";

            Assert.AreEqual(wait, res);



        }
    }
}
