using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {
        public static void PowerShellController(string argument)
        {
            
            if (argument =="list")
            {
                List<Person> people = SelectDataSource(1);
                var sortedPeople = SortByIdAscending(people);
                PrintFunctions.PrintPeople(sortedPeople, 1);

                if (argument[1] ==)
            }
            else if (argument ==)
  
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

        public static List<Person> SortByNameAscending(List<Person> peopleData)
        {
            
            var sortedPeople = peopleData.OrderBy(person => person.Name).ToList();
            return sortedPeople;
        }

        internal static List<Person> SortByIdAscending(List<Person> peopleData)
        {
            //HardcodedPeopleData _dataSource = new HardcodedPeopleData();
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByNameAscending(List<Person> peopleData)
        {
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByIdAscending(List<Person> peopleData)
        {
            //var people = _dataSource.GetPeople();
            var sortedPeople = peopleData.OrderBy(person => person.Id).Take(5).ToList();
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
