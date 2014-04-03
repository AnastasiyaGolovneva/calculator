﻿using System;
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
       
    }
}
