using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;
namespace extensionTest
{
    [TestClass]
    public class IsEmptyTests
    {
        [TestMethod]
        public void IsEmpty_WithNullString_IsTrue()
        {
            string target = null;

            Assert.IsTrue(target.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_WithEmptyString_IsTrue()
        {
            var target = string.Empty;

            Assert.IsTrue(target.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_WithString_IsFalse()
        {
            const string target = "x";

            Assert.IsFalse(target.IsEmpty());
        }
    }
}