using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsPrimeTest1()
        {
            Assert.IsTrue(Program.IsPrime(13));
        }

        [TestMethod()]
        public void IsPrimeTest2()
        {
            Assert.IsFalse(Program.IsPrime(24));
        }

        [TestMethod()]
        public void IsPrimeTest3()
        {
            Assert.IsTrue(Program.IsPrime(1));
        }

        [TestMethod()]
        public void IsPrimeTest4()
        {
            Assert.IsFalse(Program.IsPrime(99));
        }

        [TestMethod()]
        public void IsPrimeTest5()
        {
            Assert.IsTrue(Program.IsPrime(10)); // should fail
        }

        [TestMethod()]
        public void IsPrimeTest6()
        {
            Assert.IsFalse(Program.IsPrime(17)); // should fail
        }
    }
}