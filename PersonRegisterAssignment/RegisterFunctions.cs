using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;

namespace PersonRegisterAssignment
{
    internal class RegisterFunctions
    {
        public static List<Person> SortByNameAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(t => t.Name).ToList();
            return sortedPeople;
        }

        public static List<Person> SortByIdAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(t => t.Id).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByNameAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(t => t.Name).Take(5).ToList();
            return sortedPeople;
        }
        public static List<Person> SortFirstFiveByIdAscending()
        {
            var unsortedPeople = Person.GetPeople();
            var sortedPeople = unsortedPeople.OrderBy(t => t.Id).Take(5).ToList();
            return sortedPeople;
        }

        public static List<Person> FilterByKeyword()
        {
            
            string searchKeyword = Console.ReadLine() ?? "null";
            var unsortedPeople = Person.GetPeople();
            var sortedPeople 
                = unsortedPeople.Where(x => x.Name.Contains(searchKeyword.ToLower())).OrderBy(t => t.Id).Take(5).ToList();
            return sortedPeople;
        }

        

        public static void QuitApplication()
        {
            Environment.Exit(0);
        }

        public static void PrintInfo(Menu menu)
        {
            int menuChoice = menu.MenuChoice;
            string message = menuChoice switch
            {
                0 => "Ogiltigt val, välj ett alternativ mellan 1-6",
                1 => "(1) Display all suppliers and sort them by ID",
                2 => "(2) Display all suppliers and sort them by Name",
                3 => "(3) Sort suppliers by ID and display first five in list.",
                4 => "(4) Sort suppliers by Name and display first five in list.",
                5 => "(5) Search for suppliers by keyword.",
                6 => "(6) Quit application.",
                7 => "Please select an option between 1-6.",
                _ => "Please try again."
            };

            Console.WriteLine(message);
        }

        public static void PrintInfo(List<Person> combinedPeopleList)
        {
           
            //List header
            Console.WriteLine(
                "\r\n" +
                $"{"ID",-5}" +
                $"{"Name",-25}" +
                $"{"E-mail",-30}" +
                $"{"Street",-25}" +
                $"{"Post code",-15}" +
                $"{"City",-20}" +
                $"{"Business name",-30}" +
                $"{"Slogan",-50}" +
                "\r\n"
                );

           
            //int listObjectCount = combinedPeopleList.Count;
            
            for (
                int i = 0; i < combinedPeopleList.Count; i++)
                Console.WriteLine(
                    $"{combinedPeopleList[i].Id,-5}" +
                    $"{combinedPeopleList[i].Name,-25}" +
                    $"{combinedPeopleList[i].Email,-30}" +
                    $"{combinedPeopleList[i].Address.Street,-25}" +
                    $"{combinedPeopleList[i].Address.PostCode,-15}" +
                    $"{combinedPeopleList[i].Address.City,-20}" +
                    $"{combinedPeopleList[i].Company.CompanyName,-30}" +
                    $"{combinedPeopleList[i].Company.Slogan,-50}\r"
                    );
        }

        public static void GetBanner()
        {

            
            Console.WriteLine("\r\n");
            Console.WriteLine(""""
         ___ . .  _
"T$$$P"   |  |_| |_
 :$$$     |  | | |_
 :$$$                                                      "T$$$$$$$b.
 :$$$     .g$$$$$p.   T$$$$b.    T$$$$$bp.                   BUG    "Tb      T$b      T$P   .g$P^^T$$  ,gP^^T$$
  $$$    d^"     "^b   $$  "Tb    $$    "Tb    .s^s. :sssp   $$$     :$; T$$P $^b.     $   dP"     `T :$P    `T
  :$$   dP         Tb  $$   :$;   $$      Tb  d'   `b $      $$$     :$;  $$  $ `Tp    $  d$           Tbp.
  :$$  :$;         :$; $$   :$;   $$      :$; T.   .P $^^    $$$    .dP   $$  $   ^b.  $ :$;            "T$$p.
  $$$  :$;         :$; $$...dP    $$      :$;  `^s^' .$.     $$$...dP"    $$  $    `Tp $ :$;     "T$$      "T$b
  $$$   Tb.       ,dP  $$"""Tb    $$      dP ""$""$" "$"$^^  $$$""T$b     $$  $      ^b$  T$       T$ ;      $$;
  $$$    Tp._   _,gP   $$   `Tb.  $$    ,dP    $  $...$ $..  $$$   T$b    :$  $       `$   Tb.     :$ T.    ,dP
  $$$;    "^$$$$$^"   d$$     `T.d$$$$$P^"     $  $"""$ $"", $$$    T$b  d$$bd$b      d$b   "^TbsssP" 'T$bgd$P
  $$$b.____.dP                                 $ .$. .$.$ss,d$$$b.   T$b.
.d$$$$$$$$$$P  bug                                                    `T$b.
                                                                        "^^"
"""");

        }
    }
}
