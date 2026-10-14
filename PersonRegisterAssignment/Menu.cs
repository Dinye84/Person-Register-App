using PersonRegisterAssignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonRegisterAssignment
{
    internal class Menu
    {
        internal static void GetMenu(List<Person> peopleDataSource)
        {
            List<Person> printPeople = peopleDataSource;

            while (true)
            {
                PrintFunctions.PrintMenuOptions();

                string? menuSelectionInput = Console.ReadLine();
                bool isParseSuccessful = int.TryParse(menuSelectionInput, out int menuSelection);

                if (isParseSuccessful == false)
                {
                    Console.WriteLine("\n[Invalid input.Please only use numbers between 1-6.]\n");
                    continue;
                }

                

                switch (menuSelection)
                {
                    case 1:
                        
                        printPeople = RegisterFunctions.SortByNameAscending(peopleDataSource);
                        break;

                    case 2:
                        printPeople = RegisterFunctions.SortByIdAscending(peopleDataSource);
                        break;

                    case 3:
                        printPeople = RegisterFunctions.SortFirstFiveByNameAscending(peopleDataSource);
                        break;

                    case 4:
                        printPeople = RegisterFunctions.SortFirstFiveByIdAscending(peopleDataSource);
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
                                printPeople = RegisterFunctions.FilterByKeyword(peopleDataSource, keywordInput);
                                break;
                            }
                        } 
                        break;

                    case 6:
                        RegisterFunctions.QuitApplication();
                        return;

                    default:
                        Console.WriteLine("\n[Invalid input. Please enter a number between 1 and 6.]\n");
                        continue;
                }

                PrintFunctions.PrintPeople(printPeople, menuSelection);
            }
        }
    }
}
