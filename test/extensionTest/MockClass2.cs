namespace extensionTest
{
    public class MockClass2
    {
        public bool SomeMethodCalled = false;

        public void OtherMethodReturnVoid()
        {
            SomeMethodCalled = true;
        }
    }
}