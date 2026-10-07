using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterAssignment
{
    internal class Menu
    {


        //1.    Fråga efter menyalternativ
        //2.    Användaren väljer ett alternativ
        //3A.   Användaren fyller i en siffra -> Trycatch, visa felmeddelande,
        //3B    Användaren fyller i en bokstav eller annan ogiltigt tecken -> vidare till X
        //4.    Register visas.
        //5.    Menyn visas igen.
        //6.    Avsluta programmet.
        public static void DisplayMenu()
        {
            Console.WriteLine("Select menu choice 1-6");
            bool successfulParse = int.TryParse(Console.ReadLine(), out int menuChoice);

            //try
            //{ 
            //    bool successfulParse = int.TryParse(Console.ReadLine(), out int menuChoice);
            //}
            //catch ()


            

            //while (successfulParse)
            //{
                switch (menuChoice)
                {

                    case 1:
                        Console.WriteLine("Display all people by ID, ascending order");
                        List<Person> combinedPeopleDataList = Person.GetPeople();
                        RegisterFunctions.PrintInfo(combinedPeopleDataList);
                    break;
                    case 2:
                        Console.WriteLine("Display first five people by ID, ascending order");
                        break;
                    case 3:
                        Console.WriteLine("Display all people by name, ascending order");
                        break;
                    case 4:
                        Console.WriteLine("Display first five people by name, ascending order");
                        break;
                    case 5:
                        Console.WriteLine("Search for people");
                        break;
                    case 6:
                        Console.WriteLine("Quitting program");
                        break;
                //}
            }


        }

    }
}
