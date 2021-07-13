using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class SalesList
    {

        public List<Sales> selist = new List<Sales>();

        public bool CompareSales(Sales s1)
        {
            bool found = false;
            foreach (Sales se in selist)
            {
                if (s1.PropertyId == se.PropertyId)
                {
                    found = true;
                }
            }
            return found;
        }



        public void Add(Sales se)
        {
            selist.Add(se);
        }

        public void AddSales()
        {
            ////boolean to check for errors
            Sales se = new Sales();
            bool sales_id = false;
            bool sales_sq = false;
            bool sales_va = false;
            bool sales_date = false;
            bool sales_price = false;
            bool Sales_done = false;
            bool total_sales = false;
         
            do
            {
                try
                {
                    Console.Write("Enter Sales registration Number: ");
                    se.PropertyId = Convert.ToInt32(Console.ReadLine());
                    sales_id = true;
                }
                catch (FormatException) { Console.WriteLine("invalid registration number!" +
                    " Input registration number once more"); }
            } while (!sales_id);

            Console.WriteLine("Please enter Full Name ");
            se.OwnerName = Console.ReadLine();

            while (string.IsNullOrEmpty(se.OwnerName))
            {
                Console.WriteLine("Name cannot be empty! Please enter name");
                se.OwnerName = Console.ReadLine();
            }
            Console.WriteLine("Please enter Property Address");
            se.Address = Console.ReadLine();

            while (string.IsNullOrEmpty(se.Address))
            {
                Console.WriteLine("Property Address can't be empty! Input Address once more");
                se.Address = Console.ReadLine();

            }
            ////choosing location/////

            Console.WriteLine("Choose Location by using the abbreviated letters");
            Console.WriteLine("[DU]:DUBLIN \n [TA]:TALLAGHT\n [DR]:DUNDRUM " +
                "\n [CL]:CLONTARF\n [PK]:PARKWEST\n [BR]:BRAY");
            string pick = Console.ReadLine();

            if (pick.ToUpper() == "DU")
            {
                se.Location = LocationEnum.Dublin;
            }
            else if (pick.ToUpper() == "TA")
            {
                se.Location = LocationEnum.Tallaght;
            }
            else if (pick.ToUpper() == "DR")
            {
                se.Location = LocationEnum.Dundrum;
            }

            else if (pick.ToUpper() == "CL")
            {
                se.Location = LocationEnum.Clontarf;
            }
            else if (pick.ToUpper() == "PK")
            {
                se.Location = LocationEnum.Parkwest;
            }

            else if (pick.ToUpper() == "BR")
            {
                se.Location = LocationEnum.Bray;
            }
            else
                Console.WriteLine("This is not an option please enter " +
                        "DU/TA/DR/CL/PK/BR");

            ////End of location ///

            Console.WriteLine("Please enter Email Address ");
            se.OwnerEmail = Console.ReadLine();

            while (string.IsNullOrEmpty(se.OwnerEmail))
            {
                Console.WriteLine("Email cannot be empty! Please enter Email");
                se.OwnerEmail = Console.ReadLine();
            }

            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot width of rental property ");
                    se.SquareFootage = Convert.ToDouble(Console.ReadLine());
                    sales_sq = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a Valid number: !"); }
            } while (!sales_sq);



            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot length of rental property : ");
                    se.Squarelength = Convert.ToDouble(Console.ReadLine());
                    sales_sq = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a valid number!"); }
            } while (!sales_sq);



            do
            {
                try
                {
                    Console.Write("Please Enter Property Valuation: ");
                    se.Valuation = Convert.ToDouble(Console.ReadLine());
                    sales_va = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a valid number!"); }
            } while (!sales_va);


            /////choosing the renting type of property///
            Console.WriteLine("Choose Categories ");
            Console.WriteLine("\n 1-bedroom,\n  2-bedroom \n 3-bedroom \n 4-bedroom\n 5-flats\n 6-Duplex \n 7-Condos");
            Console.WriteLine("Please enter corresponding number of bedrooms ");

            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                se.RentalType = RentingTypeEnum.Onebedroom;
            }
            else if (type == 2)
            {
                se.RentalType = RentingTypeEnum.Twobedroom;
            }
            else if (type == 3)
            {
                se.RentalType = RentingTypeEnum.Threebedroom;
            }

            else if (type == 4)
            {
                se.RentalType = RentingTypeEnum.Fourbedroom;
            }

            else if (type == 5)
            {
                se.RentalType = RentingTypeEnum.flats;
            }

            else if (type == 6)
            {
                se.RentalType = RentingTypeEnum.Duplex;
            }

            else if (type == 7)
            {
                se.RentalType = RentingTypeEnum.Condos;
            }
            else
                Console.WriteLine("That is not an option ");
            Console.WriteLine($"{se.RentalType},");
            Console.ReadLine();

            ////End of type of property
            do
            {
                try
                {
                    Console.Write("Please enter the Date Entered for Property sample: YYYY-MM-DD. "); ;
                    se.DateEntered = Convert.ToDateTime(Console.ReadLine());
                    sales_date = true;
                }
                catch (FormatException) { Console.WriteLine("Please a valid Date format!"); }
            } while (!sales_date);


            do
            {
                try
                {
                    Console.Write("Please enter Asking price"); ;
                    se.AskingPrice = Convert.ToDouble(Console.ReadLine());
                    sales_price = true;
                }
                catch (FormatException) { Console.WriteLine("Please a valid number!"); }
            } while (!sales_price);

            do
            {
                try
                {
                    Console.Write("Enter number of Agreed sale "); ;
                    se.Asales = Convert.ToInt32(Console.ReadLine());
                    Sales_done = true;
                }
                catch (FormatException) { Console.WriteLine("Please a valid number!"); }
            } while (!Sales_done);


            do
            {
                try
                {
                    Console.Write("Enter total number of sale"); ;
                    se.Total = Convert.ToInt32(Console.ReadLine());
                    total_sales = true;
                }
                catch (FormatException) { Console.WriteLine("Please a valid number!"); }
            } while (!total_sales);
            ////choosing the sales option to view number of sales/sold/ saleagreed/// 
            Console.WriteLine("Select the option below that best describe your purpose");
            Console.WriteLine("[SD] SOLD\n[SE] SALES\n [SA] SALE-AGREED");
            string choose = Console.ReadLine();
            while (choose.ToUpper() != "SD" && choose.ToUpper() != "SE" && choose.ToUpper() != "SA")
            {
                Console.WriteLine("This is not an option please enter " +
                    "SD/CE/SA");
                choose = Console.ReadLine();
            }
        

            if (choose.ToUpper() == "SD")
            {
                se.Nsales = NsalesEnum.Sold;
            }
            else if (choose.ToUpper() == "SE")
            {
                se.Nsales = NsalesEnum.Sales;
            }
            else if (choose.ToUpper() == "SA")
             {
             se.Nsales = NsalesEnum.SalesAgreed;
           }

       if (!CompareSales(se))
            {
                selist.Add(se);
                Console.WriteLine("That Sales property is already added");
            }
            else
            {
                Console.WriteLine(" Sales Property already exist ");
            }
            Console.WriteLine(se.ToString(), $" the {se.OwnerName},");
            Console.ReadLine();

        }

        //showing property list//
        public void showSales()
        {
            foreach (Sales se in selist)
            {
                Console.WriteLine(se.ToString());
            }
        }
        public string searchSales()
        {
            int propertyid;
            bool found = false;
            Sales s1 = new Sales();

            Console.WriteLine("Please enter propertyID ");
            propertyid = int.Parse(Console.ReadLine());

            foreach (Sales se in selist)
            {
                if (se.PropertyId == propertyid)
                {
                    s1 = se;
                    found = true;
                }
            }
            if (found)
            {
                return s1.ToString();
            }
            else return " Property not found";

        }
        // removing property//

        public string RemoveProperty()
        {
            int propertyid;
            bool removed = false;

            Console.WriteLine("Enter registration Number:  ");
            propertyid = int.Parse(Console.ReadLine());
            for (int i = 0; i < selist.Count; i++)
            {
                if (selist[i].PropertyId == propertyid)
                {
                    selist.Remove(selist[i]);
                    removed = true;
                    break;
                }

            }
            if (removed)
            {
                return "The property was removed";
            }
            else return "The propety does not exist";
        }
    }
}
