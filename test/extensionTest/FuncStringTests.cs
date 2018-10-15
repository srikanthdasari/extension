using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;
namespace extensionTest
{
    [TestClass]
    public class FuncStringTests
    {
        [TestMethod]
        public void FunNull()
        {
            Func<string> func = null;
            Assert.IsTrue(func.Call().IsEmpty());
        }

        [TestMethod]
        public void FuncNotNull()
        {
            Func<string> func = () => "a";
            Assert.IsTrue(func.Call().IsEqualTo("a"));
        }

        [TestMethod]
        public void IfNullEmptyStr()
        {
            string target = null;
            Assert.AreEqual("", target.IfNullEmptyStr());
        }
    }
}