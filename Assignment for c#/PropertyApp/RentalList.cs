using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class RentalList
    {

        public List<Rental> relist = new List<Rental>();
        
        //compare//
        public bool CompareRen(Rental r1)
        {
            bool found = false;
            foreach (Rental re in relist)
            {
                if (r1.PropertyId == re.PropertyId)
                {
                    found = true;
                }
            }
            return found;
        }



        public void Add(Rental re)
        {
            relist.Add(re);
        }

        public void AddRental()
        {

            Rental re = new Rental();
            /////boolean to check for error
            bool new_id = false;
            bool new_sq = false;
            bool new_va = false;
            do
            {
                try
                {
                    Console.Write("Enter ID: e.g Student number or property registration number");
                    re.PropertyId = Convert.ToInt32(Console.ReadLine());
                    new_id = true;
                }
                catch (FormatException) { Console.WriteLine("invalid ID! Enter ID once more"); }
            } while (!new_id);

            Console.WriteLine("Please enter Full Name ");
            re.OwnerName = Console.ReadLine();

            while (string.IsNullOrEmpty(re.OwnerName))
            {
                Console.WriteLine("Name cannot be empty! Please enter name");
                re.OwnerName = Console.ReadLine();
            }

            Console.WriteLine("Enter property Address");
            re.Address = Console.ReadLine();

            while (string.IsNullOrEmpty(re.Address))
            {
                Console.WriteLine("Property Address can't be empty! Input Address once more");
                re.Address = Console.ReadLine();

            }
            ///////Choosing location////////////
            Console.WriteLine("Choose Location by using the abbreviated letters");
            Console.WriteLine("[DU]:DUBLIN \n [TA]:TALLAGHT\n [DR]:DUNDRUM " +
                "\n [CL]:CLONTARF\n [PK]:PARKWEST\n [BR]:BRAY");
            string pick = Console.ReadLine();

            if (pick.ToUpper() == "DU")
            {
                re.Location = LocationEnum.Dublin;
            }
            else if (pick.ToUpper() == "TA")
            {
                re.Location = LocationEnum.Tallaght;
            }
            else if (pick.ToUpper() == "DR")
            {
                re.Location = LocationEnum.Dundrum;
            }

            else if (pick.ToUpper() == "CL")
            {
                re.Location = LocationEnum.Clontarf;
            }
            else if (pick.ToUpper() == "PK")
            {
                re.Location = LocationEnum.Parkwest;
            }

            else if (pick.ToUpper() == "BR")
            {
                re.Location = LocationEnum.Bray;
            }
            else
            Console.WriteLine("This is not an option please enter " +
                    "DU/TA/DR/CL/PK/BR");
            

            Console.WriteLine("Please enter Email Address ");
            re.OwnerEmail = Console.ReadLine();

            while (string.IsNullOrEmpty(re.OwnerEmail))
            {
                Console.WriteLine("Email cannot be empty! Please enter Email");
                re.OwnerEmail = Console.ReadLine();
            }

            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot width of rental property ");
                    re.SquareFootage = Convert.ToDouble(Console.ReadLine());
                    new_sq = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a Valid number: !"); }
            } while (!new_sq);



            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot length of rental property : ");
                    re.Squarelength = Convert.ToDouble(Console.ReadLine());
                    new_sq = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a valid number!"); }
            } while (!new_sq);



            do
            {
                try
                {
                    Console.Write("Please Enter Property Valuation: ");
                    re.Valuation = Convert.ToDouble(Console.ReadLine());
                    new_va = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a valid number!"); }
            } while (!new_va);

            ////end of location////////

            /////choosing the renting type of property///
            Console.WriteLine("Choose Categories ");
            Console.WriteLine("\n 1-bedroom,\n  2-bedroom \n 3-bedroom \n 4-bedroom\n 5-flats\n 6-Duplex \n 7-Condos");
            Console.WriteLine("Please enter corresponding number of bedrooms ");

            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                re.RentalType = RentingTypeEnum.Onebedroom;
            }
            else if (type == 2)
            {
                re.RentalType = RentingTypeEnum.Twobedroom;
            }
            else if (type == 3)
            {
                re.RentalType = RentingTypeEnum.Threebedroom;
            }

            else if (type == 4)
            {
                re.RentalType = RentingTypeEnum.Fourbedroom;
            }

            else if (type == 5)
            {
                re.RentalType = RentingTypeEnum.flats;
            }

            else if (type == 6)
            {
                re.RentalType = RentingTypeEnum.Duplex;
            }

            else if (type == 7)
            {
                re.RentalType = RentingTypeEnum.Condos;
            }
            else
                Console.WriteLine("That is not an option ");
            Console.WriteLine($"{re.RentalType},");
            Console.ReadLine();


            if (!CompareRen(re))
            {
                relist.Add(re);
                Console.WriteLine("That Rental property is already added");
            }
            else
            {
                Console.WriteLine(" Rental Property already exist ");
            }
            Console.WriteLine(re.ToString(), $" the {re.OwnerName},");
            Console.ReadLine();

            ////End of type of property

        }
        //showing property list//
        public void showRental()
        {
            foreach (Rental re in relist)
            {
                Console.WriteLine(re.ToString());
            }
        }
        public string searchRental()
        {
            int propertyid;
            bool found = false;
            Rental r1 = new Rental();

            Console.WriteLine("Please enter ID ");
            propertyid = int.Parse(Console.ReadLine());

            foreach (Rental re in relist)
            {
                if (re.PropertyId == propertyid)
                {
                    r1 = re;
                    found = true;
                }
            }
            if (found)
            {
                return r1.ToString();
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
            for (int i = 0; i < relist.Count; i++)
            {
                if (relist[i].PropertyId == propertyid)
                {
                    relist.Remove(relist[i]);
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
