using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRASDemo;

namespace MyTestProject
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void FactorialOf0Is1()
        {
            //setup
            FactorialUtil f = new FactorialUtil();

            //exercise
            long result = f.Factorial(0);

            //verify
            long expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FactorialOf1Is1()
        {
            //setup
            FactorialUtil f = new FactorialUtil();

            //exercise
            long result = f.Factorial(1);

            //verify
            long expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FactorialOfXIsXTimesFactXMin1()
        {
            //setup
            FactorialUtil f = new FactorialUtil();

            //exercise
            for (long x = 2; x < 30; x++)
            {
                long result = f.Factorial(x);

                //verify
                long expected = x * f.Factorial(x-1);
                Console.WriteLine("{0}! = {1}", x, result);
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void FactorialOfNegativeThrowArgumentOutOfRangeException()
        {
            //setup
            FactorialUtil f = new FactorialUtil();

            //exercise
            try
            {
                long result = f.Factorial(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                //verify
                Assert.IsInstanceOfType(e, typeof(ArgumentOutOfRangeException));
            }
        }
    }
}
