using PersonRegisterAssignment.Resources.Texts;
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
        //Before exploring ENUM for datasources, Remove after completion.
        //private static int _selectedDataSource = 0;
        //internal static int SelectedDataSource 
        //{
        //    get { return _selectedDataSource; } 
        //    set { _selectedDataSource = value; } 
        //}

        //internal RegisterFunctions()
        //{
        //    _selectedDataSource = SelectedDataSource;
        //}

        private static DataSource _selectedDataSource = 0;
        internal static DataSource SelectedDataSource
        {
            get { return _selectedDataSource; }
            set { _selectedDataSource = value; }
        }

        internal RegisterFunctions()
        {
            _selectedDataSource = SelectedDataSource;
        }

        public enum DataSource
        {
            Hardcoded = 1,
            JsonFile = 2
        }

        //FORTSÄTT PLACERA IN ENUM OCH ERSÄTT MED BOOL
        public enum Command
        {
        sortByIdAscending,
        sortFirstFiveById,
        sortByNameAscending,
        sortFirstFiveByName,
        filterByKeyword,
        switchDataSource,
        getHelp

        }
        internal static DataSource SwitchDataSource()
        {
            bool isSuccessfulParse;
            DataSource SelectedDataSource;

            while (true)
             {   
                PrintFunctions.Print(Message.SelectDataSource);
                string? userInput = Console.ReadLine() ?? "";
                isSuccessfulParse = int.TryParse(userInput, out int parsedNumber);
                SelectedDataSource = (DataSource)parsedNumber;

                if (isSuccessfulParse == false || SelectedDataSource != DataSource.Hardcoded && SelectedDataSource != DataSource.JsonFile)
                {
                    PrintFunctions.Print(Message.InvalidDataSource);
                }
                else
                {
                    break;
                }
            }

            return _selectedDataSource = SelectedDataSource;
        }
        public static void SelectDataSource(string[] argument)
        {
            bool argumentSent = argument.Length >= 1;

            SwitchDataSource();

            if (argumentSent)
            {
                CommandController(argument);
                QuitApplication();
            }
            else if (argumentSent == false)
            {
                _selectedDataSource = SelectedDataSource;

            }
        }

        public static Command GetCommand(string[] argument)
        {

            Command selectedCommand = 0;


            if (
                argument.Length == 1 &&
                argument[0] == "list")
            {
                selectedCommand = Command.sortByIdAscending;
            }
            else if (
                argument.Length == 2 &&
                argument[0] == "list" &&
                argument[1] == "--top5")
            {
                selectedCommand = Command.sortFirstFiveById;
            }
            else if (
                argument.Length == 2 &&
                argument[0] == "list" &&
                argument[1] == "--sort")
            {
                selectedCommand = Command.sortByNameAscending;
            }
            else if (
                argument.Length == 3 &&
                argument[0] == "list" &&
                argument[1] == "--sort" &&
                argument[2] == "--top5")
            {
                selectedCommand = Command.sortFirstFiveByName;
            }
            else if (
                argument.Length == 3 &&
                argument[0] == "list" &&
                argument[1] == "--search" &&
                !string.IsNullOrWhiteSpace(argument[2]
                ))
            {
                selectedCommand = Command.filterByKeyword;
            }
            else if (
                argument[0] == "list" &&
                argument[1] == "--switch"
                )
            {
                selectedCommand = Command.switchDataSource;
            }
            else if (
                argument.Length == 2 &&
                argument[0] == "list" &&
                argument[1] == "--help"
                )
            {
                selectedCommand = Command.getHelp;
            }

            return selectedCommand;

        }
        public static void CommandController(string[] argument)
        {
            GetCommand(argument);

            Command selectedCommand = 0;

            if (selectedCommand == Command.sortByIdAscending)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople/*, 1*/);
            }
            else if (selectedCommand == Command.sortFirstFiveById)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortFirstFiveByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople/*, 2*/);
            }
            else if (selectedCommand == Command.sortByNameAscending)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople/*, 3*/);
            }
            else if (selectedCommand == Command.sortFirstFiveByName)
            {
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = SortFirstFiveByNameAscending(people);
                PrintFunctions.PrintPeople(sortedPeople/*, 4*/);
            }
            else if (selectedCommand == Command.filterByKeyword)
            {
                string searchKeyword = argument[2];
                List<Person> people = GetDataSource(SelectedDataSource);
                var sortedPeople = FilterByKeyword(people, searchKeyword);
                PrintFunctions.PrintPeople(sortedPeople/*, 5*/);
            }
            else if (selectedCommand == Command.switchDataSource)
            {
                SwitchDataSource();
            }
            
            else if (selectedCommand == Command.getHelp)
            {
                PrintFunctions.GetHelpMessage();
            }
            else
            {
                PrintFunctions.GetUnknownCommandMessage();
            }
        }
        public static List<Person> GetDataSource(DataSource source)
        {
            SelectedDataSource = source;

            
            if (SelectedDataSource == DataSource.Hardcoded)
            {
                IPeopleDataSources _dataSource = new HardcodedPeopleData();
                var people = _dataSource.GetPeople();
                return people;
            }

            else if (SelectedDataSource == DataSource.JsonFile)
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
            PrintFunctions.Print(Message.ClosingApplication);
            Environment.Exit(0);
        }   
   } 
}
