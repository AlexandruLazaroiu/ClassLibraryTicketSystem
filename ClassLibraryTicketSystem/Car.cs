using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{   /// <summary>
    /// Car class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for Car class with 2 parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="dateTime"></param>
        public Car(string licensePlate, DateTime dateTime) : base(licensePlate, dateTime)
        {
            Date = dateTime;
            LicensePlate = licensePlate;
        }
        /// <summary>
        /// base price, now is overriden from the VehicleType class method
        /// </summary>
        /// <returns>double 240</returns>
        public override double Price()
        {
            if (Brobizz==true)
            {
                return 240 * 0.95;

            }
            return 240;
        }
        /// <summary>
        /// A string returning the type of car.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }


}
