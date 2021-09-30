using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaelt : Vehicle
    {
        public StoreBaelt(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            date = Date;
            licensePlate = LicensePlate;
            Brobizz = false;
        }
        /// <summary>
        /// method checks if the user has a Brobizz and if he is passing the bridge on a weekend day
        /// </summary>
        /// <returns>.75 of price if weekend and brobizz, .95 if just brobizz,100% of tax if none of the conditions are true</returns>
        public override double Price()
        {
            if(Date.DayOfWeek==DayOfWeek.Saturday||Date.DayOfWeek==DayOfWeek.Sunday)
            {
                if (Brobizz == true)
                {
                    double weekendAndBrobizzDiscount = 240 * 0.8;
                    double finalDiscount = weekendAndBrobizzDiscount * 0.95;
                    return finalDiscount;
                }

                return 240 * 0.8;
            }

            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
