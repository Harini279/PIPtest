using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using devtest;

namespace devutest
{
    [TestClass]
    public class UnitTest1
    {
        Atest obj = new Atest();
        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(5, 5);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}
