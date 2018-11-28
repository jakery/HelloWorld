using HelloWorld.Api.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Api.Factory.Tests
{
    [TestClass()]
    public class PlaintextParadigmTests
    {
        [TestMethod()]
        public void GetHelloWorldTest()
        {
            HelloWorldFactory factory = new HelloWorldFactory(new MockSettings());
            IParadigm helloWorldGetter = factory.CreateHelloWorldGetter("plaintext");

            string result = helloWorldGetter.GetHelloWorld();
            Assert.AreEqual(result, "Hello, world!");
        }
    }
}
