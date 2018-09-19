using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundsbroenBilletLibrary;

namespace OeresundsbroenBilletLibraryTest
{
    [TestClass]
    public class ØresundBilTest
    {
        [TestMethod]
        public void TestØresundBilBrobizz()
        {
            //ASSERT
            ØresundBil bil = new ØresundBil();

            //ACT
            bil.AnvendtBrobizz = true;
            decimal pris = bil.Pris();

            //ASSERT
            Assert.AreEqual(161, pris);
        }

        [TestMethod]
        public void TestØresundBilUdenBrobizz()
        {
            //ASSERT
            ØresundBil bil = new ØresundBil();

            //ACT
            bil.AnvendtBrobizz = false;
            decimal pris = bil.Pris();

            //ASSERT
            Assert.AreEqual(410, pris);
        }
    }
}
