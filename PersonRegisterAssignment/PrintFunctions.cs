using PersonRegisterAssignment.Resources.Texts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterAssignment
{
    /// <summary>
    /// PrintMenuOptions() represents functions which controls printing information
    /// to console.
    /// </summary>
    internal class PrintFunctions
    {
        internal static void PrintMenuOptions()
        {
            Print(
                $"{Message.MenuTitle}\n\n" +
                $"{Message.MenuOptionSortById}\n" +
                $"{Message.MenuOptionSortFirstFiveById}\n" +
                $"{Message.MenuOptionSortByName}\n" +
                $"{Message.MenuOptionSortFirstFiveByName}\n" +
                $"{Message.MenuOptionSearchByKeyword}\n" +
                $"{Message.MenuOptionSwitchDataSource}\n\n" +
                $"{Message.MenuOptionQuitProgram}\n\n" +
                $"{Message.MenuOptionMenuInstructions}\n"
                );
        }

        public static void BuildMenuOptions(int menuChoice)
        {

            string menuMessage = "";
            switch (menuChoice)
            {
                case 1:
                    menuMessage = Message.MenuChoiceSortById;
                    break;
                case 2:
                    menuMessage = Message.MenuChoiceSortFirstFiveById;
                    break;
                case 3:
                    menuMessage = Message.MenuChoiceSortByName;
                        break;
                case 4: 
                    menuMessage = Message.MenuChoiceSortFirstFiveByName;
                    break;
                default:
                    menuMessage = string.Empty;
                    break;
            };
            Print(menuMessage);
        }
        internal static void BuildListHeader(List<Person> people)
        {
            Print($"{"ID",-5}" +
                $"{"Name",-25}" +
                $"{"E-mail",-30}" +
                $"{"Street",-25}" +
                $"{"Post code",-15}" +
                $"{"City",-20}" +
                $"{"Company name",-35}" +
                $"{"Slogan",-50}" +
                "\n");
        }
        internal static void BuildPeopleList(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
                Print(
                    $"{people[i].Id,-5}" +
                    $"{people[i].Name,-25}" +
                    $"{people[i].Email,-30}" +
                    $"{people[i].Address.Street,-25}" +
                    $"{people[i].Address.PostCode,-15}" +
                    $"{people[i].Address.City,-20}" +
                    $"{people[i].Company.CompanyName,-35}" +
                    $"{people[i].Company.Slogan,-50}");

            Print("\n");
        }
        public static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// PrintPeople() structures list content.
        /// </summary>
        public static void PrintPeople(List<Person> people)
        {
            var peopleCount = people.Count;
            if (peopleCount > 0)
            {
                BuildListHeader(people);
                BuildPeopleList(people);
            }

            if (peopleCount == 0/* && menuChoice <= 6*/)
            {
                Print(Message.NoResultFound);
            }
        }

        internal static void GetHelpMessage()
        {
            Print(Message.CommandLineHelp);
        }

        internal static void GetUnknownCommandMessage()
        {
            Print(Message.UnknownCommand);
        }

        internal static void GetInvalidDataSourceMessage()
        {
            Print(Message.InvalidDataSource);
        }

        internal static void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Print(Message.PersonRegisterBanner);
        }
    }
}
