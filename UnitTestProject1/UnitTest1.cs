using System;
using FinalAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] param = { "1", "2", "3", "4" };
            var myVar = new NewFile();
            var result = myVar.checkParamValue(param);
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] param = { "1", "2", "3", "4" };
            var myVar = new NewFile();
            var result = myVar.checkParam(param,"rectangle");
            Assert.IsTrue(result);
        }

    }
}
