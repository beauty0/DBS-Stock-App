using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Building
    {
        public string Address { get; set; }
        public double SquareFootage { get; set; }
        public double Squarelength { get; set; }
        public int   PropertyId { get; set; }
        public LocationEnum Location { get; set; }



        //default contructor

        public Building()
        {

        }

        //overload constructor

        public Building(string fAddress,  double sWidth, double sLength,int fProperty, LocationEnum location)
        {
           Address = fAddress;
            SquareFootage= sWidth;
            Squarelength = sLength;
            PropertyId = fProperty;
            Location = location;



        }
        // This has to be used for tosSting
        public override string ToString()
        {
            return $"{Address} as property Address, you entered the {SquareFootage} Squarefoot-Width, " +
                $"{Squarelength} as Squarefoot-length";
        }

        public double Squaretotal( double Squarelength)
        {
            return SquareFootage * Squarelength;

        }
        
    }
}
