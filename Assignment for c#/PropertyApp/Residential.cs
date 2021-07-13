using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Residential : Building
    {
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public double Valuation { get; set; }

        public Residential()
        {
        }
        //overload constructor
        public Residential(string Address, double Squarefootage, double Squarelength,int PropertyId, string rOwnerName, string rOwnerEmail, double rValuation, LocationEnum location)
           : base(Address, Squarefootage, Squarelength, PropertyId,location)
        {
            OwnerName = rOwnerName;
            OwnerEmail = rOwnerEmail;
            Valuation = rValuation;

        }
        public override string ToString()
        {
            return base.ToString() + $" Name is {OwnerName}, and your email-address is {OwnerEmail}, {Valuation} is the valuation of peoperty ";
        }

        public double Valuations(double Valuation)
        {
            return Valuation;
        }
    }
}
