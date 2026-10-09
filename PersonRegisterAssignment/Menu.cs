using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PersonRegisterAssignment
{
    public class Menu
    {
        private int _menuChoice = 0;
        public int MenuChoice
        {
            get { return _menuChoice; }
            set { _menuChoice = value; }
        }

        public Menu(int menuChoice)
        {
            _menuChoice = MenuChoice;
            
        }
        

        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintFunctions.GetBanner();
            Console.WriteLine($"Find your local LOTR supplier\r\n\r\n");

            int menuOption = 0;
            while (menuOption <= 6)
            {
                PrintFunctions.GetMenu();

                bool successfulParse = int.TryParse(Console.ReadLine(), out menuOption);

                int choice = 0;
                Menu menu;
                //Perhaps catch errors instead of just using case 6 as message?
                switch (menuOption)
                {
                    case 1:
 
                        menu = new Menu(choice);
                        var peopleNameAscending = RegisterFunctions.SortByNameAscending();
                        PrintFunctions.PrintInfo(peopleNameAscending);
                        

                        //JsonSerializerOptions options = new()
                        //{
                        //    WriteIndented = true
                        //};
                        //string json = JsonSerializer.Serialize(peopleByName, options);
                        //File.WriteAllText("person.json", json);

                        break;
                    case 2:

                        menu = new Menu(choice);
                        var peopleId = RegisterFunctions.SortByIdAscending();
                        PrintFunctions.PrintInfo(peopleId);
                        break;
                    case 3:
                        menu = new Menu(choice);
                        var firstFiveByName = RegisterFunctions.SortFirstFiveByNameAscending();
                        PrintFunctions.PrintInfo(firstFiveByName);
                        break;
                    case 4:
                        menu = new Menu(choice);
                        var firstFivePeopleÍd = RegisterFunctions.SortFirstFiveByIdAscending();
                        PrintFunctions.PrintInfo(firstFivePeopleÍd);
                        break;
                    case 5:
                        menu = new Menu(choice);
                        var peopleByKeyword = RegisterFunctions.FilterByKeyword();
                        PrintFunctions.PrintInfo(peopleByKeyword);
                        break;

                    case 6:
                        menu = new Menu(choice);
                        RegisterFunctions.QuitApplication();
                        break;

                    default:
                        menu = new Menu(choice);
                        break;



                }
                Console.ResetColor();
            }

        }


    }
}
