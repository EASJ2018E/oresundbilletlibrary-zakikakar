using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundsbroenBilletLibrary;

namespace OeresundsbroenBilletLibraryTest
{
    [TestClass]
    public class ØresundMCTest
    {
            [TestMethod]
            public void TestØresundMCBrobizz()
            {
                //ASSERT
                ØresundMC mc = new ØresundMC();

                //ACT
                mc.AnvendtBrobizz = true;
                decimal pris = mc.Pris();

                //ASSERT
                Assert.AreEqual(73, pris);
            }

        [TestMethod]
        public void TestØresundMCUdenBrobizz()
        {
            //ASSERT
            ØresundMC mc = new ØresundMC();

            //ACT
            mc.AnvendtBrobizz = false;
            decimal pris = mc.Pris();

            //ASSERT
            Assert.AreEqual(210, pris);
        }
    }
    }

