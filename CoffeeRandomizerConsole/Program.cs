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
       // List<string> listPeople = new List<string>();

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
                mensenLijst();
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


        static void RandomMize()
        {
            //hier staat randomizing in binair
            Console.WriteLine("01010010 01100001 01101110 01100100 01101111 01101101 01101001 01110011 01101001 01101110 01100111");
            //PeopleList Uitlezen, en random output genereren vanuit PeopleList... 
            //public Random rnd = new Random();
            //string randomNumber = rnd.Next(listPeople.Count);
        }





        static void mensenLijst()
        {
            Console.WriteLine("Lijst met mogelijke doelwitten: ");
            // CSV File import
            string csv = @"C:\Users\qynmt\stack\Privé\C\C#\Projects\Evilwood Development Studio's\CoffeeRandomizerCONSOLE\CoffeeRandomizerConsole\Randomizer.csv";
            // Lijst van CSV file maken.
            using (var reader = new StreamReader(csv))
                List<string> listPeople = new List<string>();
                while (!reader.EndOfStream)
                {
                    var People = reader.ReadLine();
                    Console.WriteLine(People);
                    var delimiter = People.Split(';');
                }
        }

    } 
}


   