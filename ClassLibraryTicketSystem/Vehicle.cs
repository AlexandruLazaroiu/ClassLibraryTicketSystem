using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        private string _licensePlate;

        protected Vehicle(string licensePlate, DateTime dateTime)
        {

        }

        protected string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                LicensePlate = value;
            }
        }
        /// <summary>
        /// date time for implementation in children classes
        /// </summary>
        protected DateTime Date { get; set; }
        /// <summary>
        /// abstract method for children classes
        /// </summary>
        /// <returns>price as a double</returns>
        public abstract double Price();
        /// <summary>
        /// abstract method
        /// </summary>
        /// <returns>vehicle type override</returns>
        public abstract string VehicleType();
    }
}
