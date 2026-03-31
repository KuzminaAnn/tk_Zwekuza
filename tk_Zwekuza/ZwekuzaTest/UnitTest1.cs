using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tk_Zwekuza;

namespace ZwekuzaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            var page = new Page1();
            float x1 = 2;
            float y1 = 2;
            float rez = x1 + y1;
            Assert.IsTrue(page.MathPlus(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            var page = new Page1();
            float x1 = 2;
            float y1 = 2;
            float rez = x1 - y1;
            Assert.IsTrue(page.MathMinus(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodYmn()
        {
            var page = new Page1();
            float x1 = 2;
            float y1 = 2;
            float rez = x1 * y1;
            Assert.IsTrue(page.MathYmn(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodDel()
        {
            var page = new Page1();
            float x1 = 2;
            float y1 = 2;
            float rez = x1 / y1;
            Assert.IsTrue(page.MathDel(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodPlus1()
        {
            var page = new Page1();
            float x1 = 9999999;
            float y1 = 9999999;
            float rez = x1 + y1;
            Assert.IsTrue(page.MathPlus(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodMinus1()
        {
            var page = new Page1();
            float x1 = 9999999;
            float y1 = 9999999;
            float rez = x1 - y1;
            Assert.IsTrue(page.MathMinus(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodYmn1()
        {
            var page = new Page1();
            float x1 = 9999999;
            float y1 = 9999999;
            float rez = x1 * y1;
            Assert.IsTrue(page.MathYmn(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodDel1()
        {
            var page = new Page1();
            float x1 = 9999999;
            float y1 = 9999999;
            float rez = x1 / y1;
            Assert.IsTrue(page.MathDel(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodMinus2()
        {
            var page = new Page1();
            float x1 = 9;
            float y1 = 9999999;
            float rez = x1 - y1;
            Assert.IsTrue(page.MathMinus(x1, y1), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMethodDel2()
        {
            var page = new Page1();
            float x1 = 2;
            float y1 = 0;
            float rez = x1 / y1;
            Assert.IsFalse(page.MathDel(x1, y1), Convert.ToString(rez));
        }
    }
}
