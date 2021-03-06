using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorization;

namespace MyTestClass
{
    [TestClass]
    public class FactorizerTest
    {
        Factorizer testObject;
        [TestInitialize]
        public void Initialize()
        {
            testObject = (new Factorizer());
        }

        [TestMethod]
        public void isSimpleTest()
        {
            long n = default(long);
            var actual = testObject.isSimple(n);
            var expected = 0;
            Assert.AreEqual(actual, expected);
            Assert.Fail("autogenerated");
        }

        [TestMethod]
        public void factorizeTest()
        {
            long n = default(long);
            Divider[] dividers = default(Divider[]);
            var actual = testObject.factorize(n, dividers);
            var expected = 0;
            Assert.AreEqual(actual, expected);
            Assert.Fail("autogenerated");
        }
    }
}