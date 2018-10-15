using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;
namespace extensionTest
{
    [TestClass]
    public class IsNotEmptyTests
    {
        [TestMethod]
        public void IsNotEmpty_WithNullString_IsTrue()
        {
            string target = null;

            Assert.IsFalse(target.IsNotEmpty());
        }

        [TestMethod]
        public void IsNotEmpty_WithEmptyString_IsTrue()
        {
            var target = string.Empty;

            Assert.IsFalse(target.IsNotEmpty());
        }

        [TestMethod]
        public void IsNotEmpty_WithString_IsFalse()
        {
            const string target = "x";

            Assert.IsTrue(target.IsNotEmpty());
        }
    }
}