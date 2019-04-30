using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMSTestFollowTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            MyLibFollowTDD.Math bm = new MyLibFollowTDD.Math();
            double res = bm.Add(20.50, 20.50);
            Assert.AreEqual(41, res);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            MyLibFollowTDD.Math bm = new MyLibFollowTDD.Math();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(100, res);
        }
    }
}
