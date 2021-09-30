using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltTests
    {
        /// <summary>
        /// testing the weekend method when there is brobizz discount
        /// </summary>
        [TestMethod()]
        public void PriceTestonWeekendsWithBrobizz()
        {
            StoreBaelt c = new StoreBaelt("123ABC", DateTime.Parse("11/09/2021"));
            c.Brobizz = true;
            double testValue = c.Price();
            Assert.AreEqual(182.4,testValue);
        }

        /// <summary>
        /// testing the weekend method when there's no brobizz discount
        /// </summary>
        public void PriceTestonWeekendsWithoutBrobizz()
        {
            StoreBaelt c = new StoreBaelt("123ABC", DateTime.Parse("11/09/2021"));
            c.Brobizz = false;
            double testValue = c.Price();
            Assert.AreEqual(192, testValue);
        }
    }
}