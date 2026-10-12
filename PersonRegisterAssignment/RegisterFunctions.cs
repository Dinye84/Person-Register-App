using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {
        public static List<Person> SortByNameAscending()
        {
            var people = Person.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Name).ToList();
            return sortedPeople;
        }

        public static List<Person> SortByIdAscending()
        {
            var people = Person.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByNameAscending()
        {
            var people = Person.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByIdAscending()
        {
            var people = Person.GetPeople();
            var sortedPeople = people.OrderBy(person => person.Id).Take(5).ToList();
            return sortedPeople;
        }
        public static List<Person> FilterByKeyword(string searchKeyword)
        {
            var culture = new CultureInfo("en-GB");
            var people = Person.GetPeople();
            var sortedPeople
                = people.Where(person => culture.CompareInfo.IndexOf(person.Name, searchKeyword, CompareOptions.IgnoreCase) >= 0).OrderBy(person => person.Id).ToList();
            var peopleCount = sortedPeople.Count;

            return sortedPeople; 
        }

        public static void QuitApplication()
        {
            Console.WriteLine("\nClosing application.\n");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
