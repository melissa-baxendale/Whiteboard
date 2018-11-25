using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerSwap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap.Tests
{
    [TestClass()]
    public class IntegerSwapTests
    {
        [TestMethod()]
        public void IntSwapTest1()
        {
            Assert.AreEqual("2, 3", IntegerSwap.IntSwap(3, 2));
        }

        [TestMethod()]
        public void IntSwapTest2()
        {
            Assert.AreEqual("-2, 3", IntegerSwap.IntSwap(3, -2));
        }

        [TestMethod()]
        public void IntSwapTes31()
        {
            Assert.AreEqual("2, -3", IntegerSwap.IntSwap(-3, 2));
        }

        [TestMethod()]
        public void IntSwapTes41()
        {
            Assert.AreEqual("0, 356", IntegerSwap.IntSwap(356, 0));
        }
        [TestMethod()]
        public void IntSwapTest5()
        {
            Assert.AreEqual("356, 356", IntegerSwap.IntSwap(356, 356));
        }
    }
}