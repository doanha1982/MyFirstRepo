using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            MyLib.Math bm = new MyLib.Math();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            MyLib.Math bm = new MyLib.Math();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            MyLib.Math bm = new MyLib.Math();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            MyLib.Math bm = new MyLib.Math();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
