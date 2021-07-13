using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Rental : Residential
    {
        public RentingTypeEnum RentalType { get; set; }


        public Rental()
        {
        }
        //overload constructor 
        public Rental(string Address, double Squarefootage, double Squarelength,int PropertyId, string rOwnerName, string rOwnerEmail, double rValuation, LocationEnum location,
            RentingTypeEnum rentalType)
             : base(Address, Squarefootage, Squarelength, PropertyId, rOwnerName, rOwnerEmail, rValuation,location)

        {
            RentalType = rentalType;

        }
        public override string ToString()
        {
            return base.ToString() + $" this is a {RentalType} Property";
        }

    }
}
