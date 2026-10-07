using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {
        /// <summary>
        /// Prints a structured list of information to the console.
        /// </summary>
        /// <param name="combinedPeopleList"></param>


        public static IEnumerable<Person> SortByNameAscending()
        {
            List<Person> combinedPeopleList = Person.GetPeople();
            var sortedNameAscendingPeopleList = combinedPeopleList.OrderBy(t => t.Email);
            return sortedNameAscendingPeopleList;
        }
        public static void PrintInfo(List<Person> combinedPeopleList)
        {
            List<string> structuredObject = new();
            
            int listObjectCount = combinedPeopleList.Count;

            Console.WriteLine(
                "\r\n" +    
                $"{"ID",- 5}" +
                $"{"Namn",-30}" +
                $"{"E-post",-30}" +
                $"{"Address",-40}" +
                $"{"Postnummer",-20}" +
                $"{"Företag",-20}" +
                $"{"Slogan",-50}" +
                "\r\n"
                );

            for (int i = 0; i < listObjectCount; i++)
            {
                structuredObject.Add(
                    $"{combinedPeopleList[i].Id,-5}" +
                    $"{combinedPeopleList[i].Name,-30}" +
                    $"{combinedPeopleList[i].Email,-30}" +
                    $"{combinedPeopleList[i].Address,-40}" +
                    $"{combinedPeopleList[i].PostCode,-20}" +
                    $"{combinedPeopleList[i].Company,-20}" +
                    $"{combinedPeopleList[i].Slogan,-50}"
                );
            }

            List<string> structuredList = new();

            for (int i = 0; i < listObjectCount; i++)
            {
                structuredList.Add(structuredObject[i]);
            }

            for(int i = 0; i < listObjectCount; i++ )
                Console.WriteLine(structuredList[i]);

            Console.WriteLine("\r\n");
        }

        


    }
}
