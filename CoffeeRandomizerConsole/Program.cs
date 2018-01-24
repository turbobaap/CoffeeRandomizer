using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRandomizerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }



        static bool MainMenu()
        {
            Console.WriteLine("Kies een optie: ");
            Console.WriteLine("1) Randomizer");
            Console.WriteLine("2) List");
            Console.WriteLine("3) Exit ");
            string result = Console.ReadLine();

            //Acties Om te kiezen:
                 
            if (result == "1")
            {
                RandomMize();
                return true;
            }
            else if (result == "2")
            {
                PeopleList();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Randomizer
        static void RandomMize()
        {
            //hier staat randomizing in binair
            Console.WriteLine("01010010 01100001 01101110 01100100 01101111 01101101 01101001 01110011 01101001 01101110 01100111");

            //PeopleList Uitlezen, en random output genereren vanuit PeopleList... 
            
          

            Console.WriteLine();
            Console.ReadLine();
        }


        //lijst met mensen
        static void PeopleList()
        {
            Console.WriteLine("Lijst met mogelijke doelwitten: ");
            // CSV File import
            TextReader csv = File.OpenText(@"\\locationofcsvFile.csv");
            // ff csv naar string frotten
           string getCoffee = csv.ReadLine();

            // even kijken om de waardes vanuit CSV in een ArrayList te proppen.

            //output van string getCoffee
            Console.WriteLine(getCoffee);
            Console.ReadLine();
        }


    }
}
