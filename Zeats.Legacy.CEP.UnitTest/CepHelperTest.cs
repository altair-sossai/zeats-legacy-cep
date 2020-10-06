using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.CEP.UnitTest
{
    [TestClass]
    public class CepHelperTest
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(CepHelper.IsValid("13617540"));
            Assert.IsTrue(CepHelper.IsValid("01513000"));

            Assert.IsFalse(CepHelper.IsValid("a1513000"));
            Assert.IsFalse(CepHelper.IsValid("3617540"));
            Assert.IsFalse(CepHelper.IsValid("1513000"));
        }

        [TestMethod]
        public void Format()
        {
            Assert.AreEqual("13.617-540", CepHelper.Format("13617540"));
            Assert.AreEqual("1361754", CepHelper.Format("1361754"));
            Assert.AreEqual("Lorem Ipsum", CepHelper.Format("Lorem Ipsum"));
        }
    }
}