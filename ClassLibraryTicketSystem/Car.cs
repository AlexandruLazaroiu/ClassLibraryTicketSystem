using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{   /// <summary>
    /// Car class
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Constructor for Car class with 2 parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="Date"></param>
        public Car(string licensePlate, DateTime Date)
        {

        }
        /// <summary>
        /// base price
        /// </summary>
        /// <returns>double 240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// A string returning the type of car.
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }


}
