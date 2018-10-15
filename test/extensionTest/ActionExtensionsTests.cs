using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace extensionTest
{
    [TestClass]
    public class ActionExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Call_WhenNull_DoNotCallAction()
        {
            Action action = null;
            action();
        }

        [TestMethod]
        public void Call_WhenNotNull_DoNotCallAction()
        {
            var bCalled = false;
            Action action = () => bCalled = true;
            action();

            Assert.IsTrue(bCalled);
        }

        [TestMethod]
        public void Call_WhenNotNull_WithParam()
        {
            var bCalled = false;
            Action<bool> action = (x) => bCalled = x;
            action(true);

            Assert.IsTrue(bCalled);
        }
    }
}