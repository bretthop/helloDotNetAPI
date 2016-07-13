using System;
using helloDotNetAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloDotNetTests
{
    [TestClass]
    public class HelloTests
    {
        [TestMethod]
        public void FirstTest()
        {
            HelloTestEntity testEntity = new HelloTestEntity();
            testEntity.TestProperty = "test";
            string returnedTestProperty = testEntity.ReturnTestPropertyForUnitTest();

            Assert.AreEqual("test", returnedTestProperty);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual("test", "test");
        }
    }
}
