using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class OresundMC:Vehicle
    {
        public OresundMC(string licensePlate, DateTime dateTime) : base(licensePlate, dateTime)
        {
            LicensePlate = licensePlate;
            Date = dateTime;
            Brobizz = false;
        }

        public override double Price()
        {
            if (Brobizz)
            {
                return 73;
            }

            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
