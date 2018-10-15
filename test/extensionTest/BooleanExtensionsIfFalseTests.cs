using Microsoft.VisualStudio.TestTools.UnitTesting;
using extensionlib;
namespace extensionTest
{
    [TestClass]
    public class BooleanExtensionsIfFalseTests
    {
        [TestMethod]
        public void IfFalse_WithTrue_DoNotCallAction()
        {
            true.IfFalse(() => Assert.Fail());
        }


        [TestMethod]
        public void IfFalse_WithFalse_CallAction()
        {
            var actionCalled = false;

            false.IfFalse(() => actionCalled = true);

            Assert.IsTrue(actionCalled);
        }


        [TestMethod]
        public void IfFalse_WithTrue_DoNotCallActionBool()
        {
            true.IfFalse(x => Assert.Fail());
        }


        [TestMethod]
        public void IfFalse_WithFalse_CallActionBool()
        {
            var actionCalled = true;

            false.IfFalse(x => actionCalled = x);

            Assert.IsFalse(actionCalled);
        }


        [TestMethod]
        public void IfFalse_WithTrue_DoNotCallFuncT()
        {
            MockClass1 result = true.IfFalse(x => { Assert.Fail(); return new MockClass1(); });
        }


        [TestMethod]
        public void IfFalse_WithFalse_CallFunctT()
        {
            MockClass1 result = false.IfFalse(x => new MockClass1());

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void IfFalse_WithTrue_CallFunctT_ReturnDefault()
        {
            MockClass1 result = true.IfFalse(x => new MockClass1());

            Assert.IsTrue(result == default(MockClass1));
        }
    }
}