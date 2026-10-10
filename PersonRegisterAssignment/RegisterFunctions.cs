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
        public RegisterFunctions()
        {
            
        }
        public static List<Person> SortByNameAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(person => person.Name).ToList();
            return sortedPeople;
        }

        public static List<Person> SortByIdAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(person => person.Id).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByNameAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(person => person.Name).Take(5).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByIdAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(person => person.Id).Take(5).ToList();
            return sortedPeople;
        }
          
        public static List<Person> FilterByKeyword()
        {
            var culture = new CultureInfo("en-GB");
            string searchKeyword = Console.ReadLine() ?? "null";
            var unsortedPeople = Person.GetPeople();
            var sortedPeople
                = unsortedPeople.Where(x => culture.CompareInfo.IndexOf(x.Name, searchKeyword, CompareOptions.IgnoreCase) >= 0).ToList();
            return sortedPeople;
        }



        public static void QuitApplication()
        {
            Environment.Exit(0);
        }

       
    }
}
