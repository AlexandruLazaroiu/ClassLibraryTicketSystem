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
        /// <summary>
        /// parent class for MC and Car
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="dateTime"></param>
        protected Vehicle(string licensePlate, DateTime dateTime)
        {

        }
        /// <summary>
        /// method to see the length of the license plate, 7 being the maximum allowed length
        /// </summary>
        protected string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Invalid License Plate, too many characters");
                }
                _licensePlate = value;
            }
        }
        /// <summary>
        /// date time for implementation in children classes
        /// </summary>
        protected DateTime Date { get; set; }
        /// <summary>
        /// boolean for finding the reduction in price where applicable
        /// </summary>
        public bool Brobizz { get; set; }

        /// <summary>
        /// abstract method for children classes
        /// </summary>
        /// <returns>price as a double</returns>
        public abstract double Price();
        //{
        //    if(Brobizz=true){return Price*0.95}
        //    else
        //    {
        //        return Price();
        //    }
        //};
        //tried putting the sale method here but cannot make it work
        
        /// <summary>
        /// abstract method
        /// </summary>
        /// <returns>vehicle type override</returns>
        public abstract string VehicleType();

        
    }
}
