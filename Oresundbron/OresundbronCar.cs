using System;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class OresundbronCar: Vehicle
    {
        public OresundbronCar(string licensePlate, DateTime dateTime) : base(licensePlate, dateTime)
        {
            LicensePlate = licensePlate;
            Date = dateTime;
            Brobizz = false;
        }

        public override double Price()
        {
            if (Brobizz)
            {
                return 161;
            }

            return 410;
        }
        /// <summary>
        /// method to differentiate the normal car from the oresund car
        /// </summary>
        /// <returns>string oresund car</returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
