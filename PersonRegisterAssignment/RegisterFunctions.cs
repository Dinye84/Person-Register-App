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
        private static int _selectedDataSource = 0;
        internal static int SelectedDataSource 
        {
            get { return _selectedDataSource; } 
            set { _selectedDataSource = value; } 
        }
        
        internal RegisterFunctions()
        {
            _selectedDataSource = SelectedDataSource;
        }

        public static void SelectEntryPoint(string[] argument)
        {
            bool argumentSent = argument.Length >= 1;
            if(argumentSent)
            {
                PowerShellController(argument);
                QuitApplication();
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
                argument.Length == 3 &&
                argument[0] == "list" &&
                argument[1] == "--search" &&
                !string.IsNullOrWhiteSpace(argument[2]);

            bool getHelpCommand = argument.Length == 2 && 
                argument[0] == "list" &&
                argument[1] == "--help";

            if (sortByIdAscendingCommand)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = RegisterFunctions.SortByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 1);
            }
            else if (sortFirstFiveByIdCommand)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortFirstFiveByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 2);
            }
            else if (sortByNameAscendingCommand)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 3);
            }
            else if (sortFirstFiveByNameCommand)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortFirstFiveByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 4);
            }
            else if (isFilterByKeywordCommand)
            {
                string searchKeyword = argument[2];
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = FilterByKeyword(people, searchKeyword);
                PrintFunctions.PrintPeople(sortedPeople, 5);
            }
            else if (getHelpCommand)
            {
                PrintFunctions.GetHelpMessage();
            }
            else
            {
                PrintFunctions.GetUnknownCommandMessage();
            }
        }

        public static int SelectDataSource(int selection)
        {
            _selectedDataSource = selection;
            return _selectedDataSource;
        }

        public static List<Person> GetDataSource(int selectedDataSource)
        {
            if (selectedDataSource == 1)
            {
                IPeopleDataSources _dataSource = new HardcodedPeopleData();
                var people = _dataSource.GetPeople();
                return people;
            }

            else if (selectedDataSource == 2)
            {
                IPeopleDataSources _dataSource = new ImportExternalPeople();
                var people = _dataSource.GetPeople();
                return people;
            }
            else
            {
                PrintFunctions.GetInvalidDataSourceMessage();
                QuitApplication();
            }
            return [];
        }

        internal static List<Person> SortByIdAscending(List<Person> peopleData)
        {
            var sortedPeople = peopleData.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }

        internal static List<Person> SortFirstFiveByIdAscending(List<Person> peopleData)
        {
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
            var sortedPeople = peopleData.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }

        internal static List<Person> FilterByKeyword(List<Person> people,string keywordInput)
        {
            var culture = new CultureInfo("en-GB");
            var sortedPeople = people.Where(person => culture.CompareInfo.IndexOf(person.Name, keywordInput, CompareOptions.IgnoreCase) >= 0).OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }

        internal static void QuitApplication()
        {
            Console.WriteLine("\nClosing application...\n");
            Environment.Exit(0);
        }   
   } 
}
