using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.Tests
{
    [TestClass()]
    public class OresundbronCarTests
    {
        /// <summary>
        /// testing the price on oresund, no brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            OresundbronCar c = new OresundbronCar("123ABC", DateTime.Now);
            double testPrice = c.Price();
            Assert.AreEqual(410,testPrice);
            
        }
        /// <summary>
        /// testing with brobizz active
        /// </summary>
        public void PriceTestwithBrobizz()
        {
            OresundbronCar c = new OresundbronCar("123ABC", DateTime.Now);
            c.Brobizz = true;
            double testPrice = c.Price();

            Assert.AreEqual(161, testPrice);

        }
    }
}