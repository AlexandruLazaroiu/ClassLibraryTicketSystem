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
    public class OresundMCTests
    {
        /// <summary>
        /// checking display of the type on oresund bridge for MC
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            OresundMC m = new OresundMC("123AB", DateTime.Now);
            Assert.AreEqual("Oresund MC", m.VehicleType());
        }

        [TestMethod()]
        public void OresundMCTest()
        {
            Assert.Fail();
        }
        /// <summary>
        /// checking the normal oresund mc price
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            OresundMC m = new OresundMC("123AB", DateTime.Now);
            double testvalue = m.Price();
            Assert.AreEqual(210,testvalue);
        }
        /// <summary>
        /// checking the oresund mc price with brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTestWithBrobizz()
        {
            OresundMC m = new OresundMC("123AB", DateTime.Now);
            m.Brobizz = true;
            double testvalue = m.Price();
            Assert.AreEqual(73, testvalue);
        }

        [TestMethod()]
        public void VehicleTypeTest1()
        {
            Assert.Fail();
        }
    }
}