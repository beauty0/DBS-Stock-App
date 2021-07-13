using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Sales : Rental
    {
        public DateTime DateEntered { get; set; }
        public double AskingPrice { get; set; }
        public int Asales { get; set; }
        public NsalesEnum Nsales { get; set; }
        public int Total { get; set; }


        public Sales()
        {
        }

        public Sales(string Address, double Squarefootage, double Squarelength,int PropertyId, string rOwnerName, string rOwnerEmail,
            int rValuation, LocationEnum location, RentingTypeEnum rentalType,DateTime lDate, double lprice, int asales,
            NsalesEnum nsales,int total)
            : base(Address, Squarefootage, Squarelength, PropertyId, rOwnerName, rOwnerEmail, rValuation, location, rentalType )

        {
            DateEntered = lDate;
            AskingPrice = lprice;
            Asales = asales;
            Nsales = nsales;
            Total = total;

        }


        public override string ToString()
        {
            return base.ToString() + $"the current property was entered in {DateEntered} at a Asking price of {AskingPrice} the property {Nsales}";
        }

        public double SalesRecords(int Asales) 
        {
            return AskingPrice * Asales;
        }

        public int Gettotal()
        {
            return Total;
        }

        public DateTime GetDate()
        {
            return DateEntered;
        }

    }

}
