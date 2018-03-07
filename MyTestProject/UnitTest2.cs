using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRASDemo;
using Moq;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void NormalCurrencyConversion()
        {
            //setup
            var mock = new Mock<RateProvider>();
            RateProvider r =  mock.Object;

            //when GetRate() called with parameter ("USD","SGD") returns 1.4
            mock.Setup(x => x.GetRate("USD", "SGD")).Returns(1.4);
            CurrencyConverter c = new CurrencyConverter(r);

            //exercise
            double result = c.Convert("USD", 100, "SGD");

            //verify
            double expected = 140;
            Assert.AreEqual(expected, result);

            mock.Setup(x => x.GetRate("USD", "SGD")).Returns(1.5);
            result = c.Convert("USD", 100, "SGD");
            expected = 150;
            Assert.AreEqual(expected, result);

            mock.Setup(x => x.GetRate("USD", "XXX")).Throws(new InvalidOperationException());

        }
    }
}
