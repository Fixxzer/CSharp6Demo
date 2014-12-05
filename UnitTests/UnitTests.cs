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
    }
}
