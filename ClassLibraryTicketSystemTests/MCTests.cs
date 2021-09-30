using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            MC m = new MC("123AB", DateTime.Now);
            double testValue = m.Price();
            Assert.AreEqual(125, testValue);
            
        }
        /// <summary>
        /// testing the reduced price brobizz method
        /// </summary>
        [TestMethod()]
        public void BrobizzTest()
        {
            MC m = new MC("123AB", DateTime.Now);
            m.Brobizz = true;
            double testValue = m.Price();
            Assert.AreEqual(118.75, testValue);

        }

        [TestMethod()]
        public void VehicleTest()
        {
            //arrange
            MC m = new MC("123AB", DateTime.Now);

            //act

            string testValue = m.VehicleType();
            //assert
            Assert.AreEqual("MC", testValue);
        }
    }
}