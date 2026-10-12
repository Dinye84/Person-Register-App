using PersonRegisterAssignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonRegisterAssignment
{
    public class Menu
    {
        public static void GetMenu()
        {
 
            while (true)
            {
                PrintFunctions.PrintMenuOptions();

                string? menuSelectionInput = Console.ReadLine();
                bool isParseSuccessful = int.TryParse(menuSelectionInput, out int menuSelection);

                if (isParseSuccessful == false)
                {
                    Console.WriteLine("\n[Invalid input.Please enter a number between 1 and 6.]\n");
                    continue;
                }

                var people = new List<Person>();

                switch (menuSelection)
                {
                    case 1:
                        people = RegisterFunctions.SortByNameAscending();
                        break;

                    case 2:
                        people = RegisterFunctions.SortByIdAscending();
                        break;

                    case 3:
                        people = RegisterFunctions.SortFirstFiveByNameAscending();
                        break;

                    case 4:
                        people = RegisterFunctions.SortFirstFiveByIdAscending();
                        break;

                    case 5:

                        while (true)
                        {
                            Console.Write("\nEnter keyword: ");
                            string keywordInput = Console.ReadLine() ?? "";
                            var isKeywordNullOrWhiteSpace = string.IsNullOrWhiteSpace(keywordInput);

                            if (isKeywordNullOrWhiteSpace == true)
                            {
                                Console.WriteLine("\nYour keyword is null or empty, please try again!");
                            }
                            else
                            {
                                people = RegisterFunctions.FilterByKeyword(keywordInput);
                                break;
                            }
                        } 
                        break;

                    case 6:
                        RegisterFunctions.QuitApplication();
                        return;

                    default:
                        Console.WriteLine("\nInvalid input.Please enter a number between 1 and 6.");
                        break;
                }

                PrintFunctions.PrintPeople(people, menuSelection);
            }
        }
    }
}
