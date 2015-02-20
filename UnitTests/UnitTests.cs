using System;
using CSharp6Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Truncate_WithNull_ReturnsNull()
        {
            Assert.AreEqual<string>(null, NullConditionalOperator.TruncateOld(null, 42));
            Assert.AreEqual<string>(null, NullConditionalOperator.TruncateNew(null, 42));
        }

        //[TestMethod]
        //[Row(2)]
        //public void TestTester(int val)
        //{
        //    Assert.AreEqual(val, NullConditionalOperator.Tester(val));
        //}

        [TestMethod]
        public void NameOf_UsingNameofExpressionInArgumentNullException()
        {
            try
            {
                NameofExpressions.ThrowArgumentNullExceptionUsingNameOf("data");
                Assert.Fail("This code should not be reached");
            }
            catch (ArgumentNullException exception)
            {
                Assert.AreEqual<string>("param1", exception.ParamName);
            }
        }
    }
}
