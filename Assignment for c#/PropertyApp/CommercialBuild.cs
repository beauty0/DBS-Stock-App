using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class CommercialBuild: Building
    {
        public double Rates { get; set; }
        public CbuildingEnum cbuilding { get; set; }
        public double Result { get; set; }

        public CommercialBuild()
        {
        }
        //overload constructor
        public CommercialBuild(string fAddress, double sWidth, double sLength, double cRates, int fProperty, LocationEnum location,
            CbuildingEnum type,double result)
            : base(fAddress, sWidth, sLength, fProperty,location)
        {
            this.Rates = cRates;
            this.cbuilding = type;
           this. Result = result;
        }
        public override string ToString()
        {
            return base.ToString() + $" you entered {Rates} as rate, for selected {cbuilding}";
        }

        public double YearRates(double Rates)//if here is double
        {
            return Rates * 12;//here has to double 

        }

        public double Results(double Result)
        {
            return Result;
        }

    }
}
