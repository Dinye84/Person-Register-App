using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {

        public static void SelectEntryPoint(string[] argument)
        {
            bool argumentSent = argument.Length >= 1;

            if(argumentSent)
            {
                PowerShellController(argument);
            }
        }
        public static void PowerShellController(string[] argument)
        {
            bool sortByIdAscendingCommand = 
                argument.Length == 1 &&
                argument[0] == "list";

            bool sortFirstFiveByIdCommand = 
                argument.Length == 2 &&
                argument[0] == "list" &&
                argument[1] == "--top5";

            bool sortByNameAscendingCommand = 
                argument.Length == 2 &&
                argument[0] == "list" &&
                argument[1] == "--sort";

            bool sortFirstFiveByNameCommand = 
                argument.Length == 3 &&
                argument[0] == "list" &&
                argument[1] == "--sort" &&
                argument[2] == "--top5";

            bool isFilterByKeywordCommand = 
                argument.Length >= 3 &&
                argument[0] == "list" &&
                argument[1] == "--search";

            //Console.WriteLine(

            //    $"sortByIdAscendingCommand = {sortByIdAscendingCommand}\n" +
            //    $"sortFirstFiveByIdCommand = {sortFirstFiveByIdCommand}\n" +
            //    $"sortByNameAscendingCommand = {sortByNameAscendingCommand}\n" +
            //    $"sortFirstFiveByNameCommand = {sortFirstFiveByNameCommand}\n" +
            //    $"isFilterByKeyword = {isFilterByKeyword}\n"
            //    );

            if (sortByIdAscendingCommand)
            {
                List<Person> people = SelectDataSource(1);
                var sortedPeople = RegisterFunctions.SortByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 1);
            }
            else if (sortFirstFiveByIdCommand)
            {

                List<Person> people = SelectDataSource(1);
                var sortedPeople = SortFirstFiveByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 2);
            }
            else if (sortByNameAscendingCommand)
            {
                List<Person> people = SelectDataSource(1);
                var sortedPeople = SortByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 3);
            }
            else if (sortFirstFiveByNameCommand)
            {
                List<Person> people = SelectDataSource(1);
                var sortedPeople = SortFirstFiveByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 4);
            }
            else if (isFilterByKeywordCommand)
            {
                string searchKeyword = argument[2];
                List<Person> people = SelectDataSource(1);
                var sortedPeople = FilterByKeyword(people, searchKeyword);
                PrintFunctions.PrintPeople(sortedPeople, 5);
            }
        }
        public static List<Person> SelectDataSource(int choice)
        {
            do
            {
                if (choice == 1)
                {
                    IPeopleDataSources _dataSource = new HardcodedPeopleData();
                    var people = _dataSource.GetPeople();
                    
                    return people;
                }

                else if (choice == 2)
                {
                    IPeopleDataSources _dataSource = new ImportExternalPeople();
                    var people = _dataSource.GetPeople();

                    return people;
                }
                else
                {
                    Console.WriteLine($"Invalid data source selection.\n" +
                        $"To select a data source, add the value \"1\" or \"2\" in Main() / RegisterFunctions.SelectDataSource()\n" +
                        $"Application closing...\n");
                    Environment.Exit(0);
                }

            } while (choice != 1 | choice !=2 );
            return [];
        }

        

        internal static List<Person> SortByIdAscending(List<Person> peopleData)
        {
            //HardcodedPeopleData _dataSource = new HardcodedPeopleData();
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByIdAscending(List<Person> peopleData)
        {
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Id).Take(5).ToList();
            return sortedPeople;
        }
        public static List<Person> SortByNameAscending(List<Person> peopleData)
        {

            var sortedPeople = peopleData.OrderBy(person => person.Name).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByNameAscending(List<Person> peopleData)
        {
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }
        internal static List<Person> FilterByKeyword(List<Person> people,string keywordInput)
        {
            var culture = new CultureInfo("en-GB");
            //var people = _dataSource.GetPeople();
            var sortedPeople = people.Where(person => culture.CompareInfo.IndexOf(person.Name, keywordInput, CompareOptions.IgnoreCase) >= 0).OrderBy(person => person.Id).ToList();

            return sortedPeople;
        }
        internal static void QuitApplication()
        {
            Console.WriteLine("\nClosing application.\n");
            Console.ResetColor();
            Environment.Exit(0);
        }
   } 
}
