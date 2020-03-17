using BusinessLayer;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace DemoTest
{
    [TestClass]
    public class BLClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int Numerator = 10;
            int Denominator = 2;
            int expected = 5;
            int actual = 0;
            BLClass B = new BLClass();
            actual = B.Divide(Numerator.ToString(), Denominator.ToString());

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest2()
        {
            int Numerator = 0;
            int Denominator = 2;
            int expected = 0;
            
            BLClass B = new BLClass();
            int actual = B.Divide(Numerator.ToString(), Denominator.ToString());
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest3()
        {
           int Numerator =10;
            int Denominator = 0;
            
            BLClass b = new BLClass();
            var ex = Assert.ThrowsException <DivideByZeroException > (() => b.Divide(Numerator.ToString(), Denominator.ToString()));
            Assert.AreEqual("cannot divide by zero",ex.Message);
        }
        [TestMethod]
        public void DivideTest4()
        {
           //int Numerator = "abc";
           // int Denominator = "z";
            BLClass b = new BLClass();
            var ex = Assert.ThrowsException<FormatException>(() => b.Divide("abc","z"));
            Assert.AreEqual("only Numbers", ex.Message);
        }
    }
}
