using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Summary description for CalculTest
    /// </summary>
    [TestClass]
    public class CalculTest
    {
        public CalculTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        protected Calcul newCalcul;

        [TestInitialize()]
        public void MyTestInitialize() 
        {
            newCalcul = new Calcul();
        }

        [TestMethod]
        public void CalctInit()
        {            
            double expected = 0;
            double actual = newCalcul.getData();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctSetGet()
        {
            newCalcul.setData(2);
            double expected = 2;
            double actual = newCalcul.getData();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctPlus()
        {
            double expected = newCalcul.getData() + 5;
            double actual = newCalcul.plus(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctMinus()
        {
            newCalcul.setData(7);
            double expected = 2;
            double actual = newCalcul.minus(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctMinus2()
        {
            newCalcul.setData(8);
            double expected = 3;
            double actual = newCalcul.minus(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctMulti()
        {
            newCalcul.setData(8);
            double expected = 24;
            double actual = newCalcul.multi(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctMulti2()
        {
            newCalcul.setData(8);
            double expected = 48;
            double actual = newCalcul.multi(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctDiv()
        {
            newCalcul.setData(8);
            double expected = 4;
            double actual = newCalcul.div(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctDiv2()
        {
            newCalcul.setData(8);
            double expected = 8;
            double actual = newCalcul.div(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctFactorial()
        {
            double expected = 24;
            double actual = newCalcul.factorial(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctFactorial2()
        {
            double expected = 120;
            double actual = newCalcul.factorial(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctCos()
        {
            newCalcul.setData(Math.PI / 4);
            double expected = Math.Cos(Math.PI/4);
            double actual = newCalcul.cos();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctSin()
        {
            newCalcul.setData(Math.PI / 4);
            double expected = Math.Sin(Math.PI / 4);
            double actual = newCalcul.sin();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctTang()
        {
            newCalcul.setData(Math.PI / 4);
            double expected = Math.Tan(Math.PI / 4);
            double actual = newCalcul.tang();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctSqrt()
        {
            newCalcul.setData(100);
            double expected =10;
            double actual = newCalcul.sqrt();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctExp()
        {
            newCalcul.setData(3);
            double expected = Math.Exp(3);
            double actual = newCalcul.exp();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctCos2PlusSin2()
        {
            newCalcul.setData(Math.PI / 3);
            double expected = 1.0;
            Calcul c1 = new Calcul(newCalcul.cos());
            Calcul c2 = new Calcul(newCalcul.sin());
            double actual = c1.square() + c2.square();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctSquare()
        {
            newCalcul.setData(3);
            double expected = 9;
            double actual = newCalcul.square();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctLog()
        {
            newCalcul.setData(3);
            double expected = Math.Log(3);
            double actual = newCalcul.log();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctPow()
        {
            newCalcul.setData(3);
            double expected = Math.Pow(3, 4);
            double actual = newCalcul.pow(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctExpress01()
        {
            newCalcul.setData(4);
            double expected = Math.Log(4) / Math.Exp(4);
            Calcul c1 = new Calcul(newCalcul.log());
            Calcul c2 = new Calcul(newCalcul.exp());
            double actual = c1.div(c2.getData());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctExpress02()
        {
            newCalcul.setData(81);
            double expected = 81;
            Calcul c1 = new Calcul(newCalcul.sqrt());
            Calcul c2 = new Calcul(c1.square());
            double actual = c2.getData();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalctExpress03()
        {
            newCalcul.setData(4);
            double expected = 4*5 + Math.Cos((double)96/34);
            Calcul c1 = new Calcul(newCalcul.multi(5));
            Calcul c2 = new Calcul((new Calcul(96)).div(34));
            double actual = c1.plus(c2.cos());
            Assert.AreEqual(expected, actual);
        }

        
       
    }
}
