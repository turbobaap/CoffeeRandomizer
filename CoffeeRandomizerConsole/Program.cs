using System;
using System.Collections.Generic;
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
                List();
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
            Console.WriteLine("Hier komt de Randomizer");
            Console.ReadLine();
        }


        //lijst met mensen
        static void List()
        {
            Console.WriteLine("Hier komt de Lijst!");
            Console.ReadLine();
        }


    }
}
