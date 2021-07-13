using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Program
    {
        static void Main(string[] args)

        {
            CommercialBuildList comList = new CommercialBuildList();
            RentalList relist = new RentalList();
            SalesList selist = new SalesList();

            int choice;
           
            bool keepGoing = true;


     while (keepGoing)


            {
                Console.WriteLine("*****************Commercial Property******************");
                Console.WriteLine("1. Add a new Property");
                Console.WriteLine("2. Search for Property");
                Console.WriteLine("3. Remove a Property");
                Console.WriteLine("4. Show all Property");
                Console.WriteLine("5. Quit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        comList.AddCommercialBuild();
                        break;

                    case 2:
                        Console.WriteLine(comList.findingProperty());
                        break;
                    case 3:
                        Console.WriteLine(comList.RemoveProperty());
                        break;
                    case 4:
                        comList.showProperty();
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }

            }



            {
                Console.WriteLine("*****************Rental Property******************");
                Console.WriteLine("1. Add a new Property");
                Console.WriteLine("2. Search for Rental Property");
                Console.WriteLine("3. Remove a Property");
                Console.WriteLine("4. Show all Property");
                Console.WriteLine("5. Quit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        relist.AddRental();
                        break;

                    case 2:
                        Console.WriteLine(relist.searchRental());
                        break;
                    case 3:
                        Console.WriteLine(relist.RemoveProperty());
                        break;
                    case 4:
                        relist.showRental();
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;

                }

            }
          
             int tab;

            {
                Console.WriteLine("*****************Sales Property******************");
                Console.WriteLine("1. Add a new Property");
                Console.WriteLine("2. Search for Property");
                Console.WriteLine("3. Remove a Property");
                Console.WriteLine("4. Show all Property");
                Console.WriteLine("5. Quit");
                tab = int.Parse(Console.ReadLine());
                switch (tab)
                {
                    case 1:
                        selist.AddSales();
                        break;

                    case 2:
                        Console.WriteLine(selist.searchSales());
                        break;
                    case 3:
                        Console.WriteLine(selist.RemoveProperty());
                        break;
                    case 4:
                        selist.showSales();
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;

                }
            }
        }

    }
}
    

       
  
