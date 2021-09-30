using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            //arrange

            //act

            //assert
            Assert.Fail();
        }
        /// <summary>
        /// testing the price method
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            Car c = new Car("123AB", DateTime.Now);
            double testValue = c.Price();
            Assert.AreEqual(240,testValue);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            Car c = new Car("123AB", DateTime.Now);
            
            //act

            string testValue = c.VehicleType();
            //assert
            Assert.AreEqual("Car", testValue);
            
        }
    }
}