using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle

    {
    public MC(string licensePlate, DateTime date):base(licensePlate,date)
    {

    }

    public override double Price()
    {
        if (Brobizz == true)
        {
            double salePrice = 125- (125 * 0.05);
            return salePrice;
        }else
        return 125;
    }

    public override string VehicleType()
    {
        return "MC";
    }
    }
}
