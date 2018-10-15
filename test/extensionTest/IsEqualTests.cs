using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;
namespace extensionTest
{
    [TestClass]
    public class IsEqualTests
    {
        [TestMethod]
        public void IsEqualTo_WithLeftNull_WithRighNull_IsTrue()
        {
            string targetLeft = null;
            string targetRight = null;

            var result = targetLeft.IsEqualTo(targetRight);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEqualTo_WithLeftEmpty_WithRighNull_IsTrue()
        {
            string targetLeft = string.Empty;
            string targetRight = null;

            var result = targetLeft.IsEqualTo(targetRight);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEqualTo_WithLeftString_WithRighString_IsTrue()
        {
            string targetLeft = "x";
            string targetRight = "x";

            var result = targetLeft.IsEqualTo(targetRight);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEqualTo_WithLeftString_WithRighString_IsFalse()
        {
            string targetLeft = "x";
            string targetRight = "a";

            var result = targetLeft.IsEqualTo(targetRight);

            Assert.IsFalse(result);
        }
    }
}