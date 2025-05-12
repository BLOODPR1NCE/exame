using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SredArifm.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new TestArifm();
            Assert.AreEqual(test.arifm(), 1);
        }
    }
}