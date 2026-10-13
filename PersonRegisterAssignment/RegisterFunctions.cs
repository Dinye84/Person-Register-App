using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {
        private static IPeopleDataSources _dataSource = new HardcodedPeopleData();
        internal static List<Person> SortByNameAscending()
        {
            var  people = _dataSource.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Name).ToList();
            return sortedPeople;
        }

        internal static List<Person> SortByIdAscending()
        {
            var people = _dataSource.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByNameAscending()
        {
            var people = _dataSource.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }
        internal static List<Person> SortFirstFiveByIdAscending()
        {
            var people = _dataSource.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Id).Take(5).ToList();
            return sortedPeople;
        }
        internal static List<Person> FilterByKeyword(string searchKeyword)
        {
            var culture = new CultureInfo("en-GB");
            var people = _dataSource.GetPeople();
            var sortedPeople
                = people.Where(
                    person => culture.CompareInfo
                    .IndexOf(person.Name, searchKeyword, CompareOptions.IgnoreCase) >= 0)
                    .OrderBy(person => person.Id)
                    .ToList();

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
