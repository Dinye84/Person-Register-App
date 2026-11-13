using PersonRegisterAssignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PersonRegisterAssignment.Resources.Texts;

namespace PersonRegisterAssignment
{
    internal class Menu
    {
        internal static void GetMenu(List<Person> peopleDataSource)
        {
            List<Person> printPeople = [];

            while (true)
            {
                PrintFunctions.PrintMenuOptions();

                string? menuSelectionInput = Console.ReadLine();
                bool isParseSuccessful = int.TryParse(menuSelectionInput, out int menuSelection);

                if (isParseSuccessful == false)
                {
                    PrintFunctions.Print(Message.InvalidEntryPoint);
                    continue;
                }

                switch (menuSelection)
                {
                    case 1:

                        printPeople = RegisterFunctions.SortByIdAscending(peopleDataSource);
                        break;
                    case 2:
                        printPeople = RegisterFunctions.SortFirstFiveByIdAscending(peopleDataSource);
                        break;

                    case 3:
                        printPeople = RegisterFunctions.SortByNameAscending(peopleDataSource);
                        break;
                    case 4:
                        printPeople = RegisterFunctions.SortFirstFiveByNameAscending(peopleDataSource);
                        break;
                    case 5:

                        while (true)
                        {
                            PrintFunctions.Print(Message.EnterKeyword);
                            string keywordInput = Console.ReadLine() ?? "";
                            var isKeywordNullOrWhiteSpace = string.IsNullOrWhiteSpace(keywordInput);

                            if (isKeywordNullOrWhiteSpace == true)
                            {
                                PrintFunctions.Print(Message.NullOrEmpty);
                            }
                            else
                            {
                                printPeople = RegisterFunctions.FilterByKeyword(peopleDataSource, keywordInput);
                                break;
                            }
                        } 

                        break;
                    case 6:
                        RegisterFunctions.SwitchDataSource();
                        break;
                    case 7:
                        RegisterFunctions.QuitApplication();
                        return;

                    default:
                        PrintFunctions.Print(Message.InvalidMenuChoice);
                        continue;
                }

                PrintFunctions.BuildMenuOptions(menuSelection);
                PrintFunctions.PrintPeople(printPeople);

            }
        }
    }
}
