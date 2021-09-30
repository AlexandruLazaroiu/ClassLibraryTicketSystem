using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{/// <summary>
/// class for Motorcycles, inherits from Vehicle
/// </summary>
    public class MC : Vehicle

    {
    public MC(string licensePlate, DateTime date):base(licensePlate,date)
    {

    }
        /// <summary>
        /// price method for our MC, overrides the Vehicle method with same name
        /// </summary>
        /// <returns></returns>
    public override double Price()
    {
        if (Brobizz == true)
        {
            double salePrice = 125- (125 * 0.05);
            return salePrice;
        }else
        return 125;
    }
        /// <summary>
        /// now method overrides the method with the same name in Vehicle class
        /// </summary>
        /// <returns>MC</returns>
    public override string VehicleType()
    {
        return "MC";
    }
    }
}
