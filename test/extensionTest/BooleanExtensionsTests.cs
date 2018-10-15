using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;

namespace extensionTest
{
    [TestClass]
    public class BooleanExtensionsTests
    {
        [TestMethod]
        public void IfTrue_WithFalse_DoNotCallAction()
        {
            false.IfTrue(() => Assert.Fail());
        }


        [TestMethod]
        public void IfTrue_WithTrue_CallAction()
        {
            var actionCalled = false;

            true.IfTrue(() => actionCalled = true);

            Assert.IsTrue(actionCalled);
        }


        [TestMethod]
        public void IfTrue_WithFalse_DoNotCallActionBool()
        {
            false.IfTrue(x => Assert.Fail());
        }


        [TestMethod]
        public void IfTrue_WithTrue_CallActionBool()
        {
            var actionCalled = false;

            true.IfTrue(x => actionCalled = x);

            Assert.IsTrue(actionCalled);
        }


        [TestMethod]
        public void IfTrue_WithFalse_DoNotCallFuncT()
        {
            MockClass1 result = false.IfTrue(x => { Assert.Fail(); return new MockClass1(); });
        }


        [TestMethod]
        public void IfTrue_WithTrue_CallFunctT()
        {
            MockClass1 result = true.IfTrue(x => new MockClass1());

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IfTrue_WithFalse_DoNotCallFunctT_ReturnDefaultT()
        {
            MockClass1 result = false.IfTrue(x => new MockClass1());

            Assert.IsTrue(result == default(MockClass1));
        }
    }
}