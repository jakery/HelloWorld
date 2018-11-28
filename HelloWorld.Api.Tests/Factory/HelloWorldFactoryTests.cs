using HelloWorld.Api.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorld.Api.Factory.Tests
{
    [TestClass()]
    public class HelloWorldFactoryTests
    {
        private HelloWorldFactory factory;

        [TestInitialize()]
        public void Startup()
        {
            factory = new HelloWorldFactory(new MockSettings());
        }

        [TestMethod()]
        public void CreateHelloWorldGetter_NoParameter()
        {
            var helloWorldGetter = factory.CreateHelloWorldGetter();
            string result = helloWorldGetter.GetHelloWorld();

            Assert.AreEqual(result, "Hello, world!");
        }

        [TestMethod()]
        public void CreateHelloWorldGetter_StringParameter()
        {
            var helloWorldGetter = factory.CreateHelloWorldGetter("plaintext");
            string result = helloWorldGetter.GetHelloWorld();

            Assert.AreEqual(result, "Hello, world!");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateHelloWorldGetter_BadString()
        {
            var helloWorldGetter = factory.CreateHelloWorldGetter("potato");
        }

        [TestMethod()]
        public void CreateHelloWorldGetter_EnumParameter()
        {
            var helloWorldGetter = factory.CreateHelloWorldGetter(ParadigmName.Plaintext);
            string result = helloWorldGetter.GetHelloWorld();

            Assert.AreEqual(result, "Hello, world!");
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void CreateHelloWorldGetter_NotImplementedEnumParameters()
        {
            var helloWorldGetter = factory.CreateHelloWorldGetter(ParadigmName.WebApi);
        }


    }
}