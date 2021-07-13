using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class CommercialBuildList
    {
        public List<CommercialBuild> comList = new List<CommercialBuild>();
     
        public bool ComparecomBub(CommercialBuild c1)
        {
            bool found = false;
            foreach (CommercialBuild c in comList)
            {
                if (c1.PropertyId == c.PropertyId)
                {
                    found = true;
                }
            }
            return found;
        }


        public void Add(CommercialBuild c)
        {
            comList.Add(c);
        }

        public void AddCommercialBuild()
        {
            CommercialBuild c = new CommercialBuild();

            bool new_int = false;
            bool new_double = false;
            bool new_rates = false;
            ///Declaring values for the property rating per location address\\\\\\\
            ///This part is to the rate per location of property\\\\\
            ///example the rate of property in dublin is 20% higher than property in tallaght///
            ///As the user adds the property they can as well check the rate with same price for the other places//
            double D = 20;
            double CL = 5;
            double P = 6;
            double T = 8;
            double DU = 30;
            double Br = 35;

            ///End of Declaring values for the property rating per location address\\\\\\\
            do
            {
                try
                {
                    Console.Write("Users ID: ");
                    c.PropertyId = Convert.ToInt32(Console.ReadLine());
                    new_int = true;
                }
                catch (FormatException) { Console.WriteLine("invalid Users ID! Input the ID once more"); }
            } while (!new_int);
            

            Console.WriteLine("Please enter the property address");
            c.Address = Console.ReadLine();
            while (string.IsNullOrEmpty(c.Address))
            {
                Console.WriteLine("Address can't be empty! Input the Address once more");
                c.Address = Console.ReadLine();
            }
            ////////////End of enter Rates \\\\\\\\\\\\\\\\
            

            do
            {
                try
                {
                    Console.Write("Enter Property Rate to check per location: ");
                    c.Rates = Convert.ToDouble(Console.ReadLine());
                    new_rates = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a Valid number: !"); }
            } while (!new_rates);
            //////////////End of enter Rates \\\\\
            Console.WriteLine(" Select Location");
            Console.WriteLine("Dublin\n Tallaght\n Clontarf\n Dundrum\n Bray\n Parkwest");

            Console.ReadLine();

            LocationEnum ciom = LocationEnum.Dublin;
            if (ciom == LocationEnum.Dublin)
            {
                c.Result = c.Rates + D;
            }
            else if (ciom == LocationEnum.Tallaght)
            {
                c.Result = c.Rates + T;
            }
            else if (ciom == LocationEnum.Clontarf)
            {
                c.Result = c.Rates + CL;
            }

            else if (ciom == LocationEnum.Dundrum)
            {
                c.Result = c.Rates + DU;
            }

            else if (ciom == LocationEnum.Bray)
            {
                c.Result = c.Rates + Br;
            }

            else if (ciom == LocationEnum.Parkwest)
            {
                c.Result = c.Rates + P;
            }
            else
                Console.WriteLine("Location not listed ");


            //////////////Get Squarefoot of property by entering length and Width of property \\\\\\\\\\\
            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot width of property ");
                    c.SquareFootage = Convert.ToDouble(Console.ReadLine());
                    new_double = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a Valid number: !"); }
            } while (!new_double);

            

            do
            {
                try
                {
                    Console.Write("Please Enter Sq-foot length of property: ");
                    c.Squarelength = Convert.ToDouble(Console.ReadLine());
                    new_double = true;
                }
                catch (FormatException) { Console.WriteLine("Please enter a valid number!"); }
            } while (!new_double);

            //////////////End of Squarefoot of property by entering length and Width of property \\\\\\\\\\\     

            Console.WriteLine(" Choose property type");
            Console.WriteLine("1.Retail\n 2.Industrial\n 3.Office");
            Console.WriteLine("Please enter a number corresponding to the type of Property");
            int Option = int.Parse(Console.ReadLine());

            if (Option == 1)
            {
                c.cbuilding = CbuildingEnum.Retail;
            }
            else if (Option == 2)
            {
                c.cbuilding = CbuildingEnum.Industrial;
            }
            else if (Option == 3)
            {
                c.cbuilding = CbuildingEnum.Office;
            }
            else
                Console.WriteLine("That is not an option ");
            Console.WriteLine($"{c.cbuilding},");
            Console.ReadLine();


            if (!ComparecomBub(c))
            {
                comList.Add(c);
                Console.WriteLine("That property is already added");
            }
            else
            {
                Console.WriteLine("Property already exist ");
            }
            Console.WriteLine(c.ToString(), $" the {c.cbuilding},");
            Console.WriteLine($"The total Squarefoot for {c.SquareFootage}x {c.Squarelength} Property is {c.Squaretotal(c.Squarelength)}");
            Console.WriteLine($"The cost Of Property type selected base on location rate is {c.Result}%,");
            Console.WriteLine($"Cost of Property per year is {c.YearRates(c.Rates)}");
            Console.ReadLine();
        }





        //showing property list//
        public void showProperty()
        {
            foreach (CommercialBuild c in comList)
            {
                Console.WriteLine(c.ToString());
            }
        }  
        public string findingProperty()
        {
            int propertyid;
            bool found = false;
            CommercialBuild c1 = new CommercialBuild();

            Console.WriteLine("Please enter propertyID ");
            propertyid = int.Parse(Console.ReadLine());

            foreach (CommercialBuild c in comList)
            {
                if (c.PropertyId == propertyid)
                {
                    c1 = c;
                    found = true;
                }
            }
            if (found)
            {
                return c1.ToString();
            }
            else return " Property not found";

        }
        // removing property

        public string RemoveProperty()
        {
            int propertyid;
            bool removed = false;

            Console.WriteLine("Please enter propertyID ");
            propertyid = int.Parse(Console.ReadLine());
            for (int i = 0; i < comList.Count; i++)
            {
                if (comList[i].PropertyId == propertyid)
                {
                    comList.Remove(comList[i]);
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
