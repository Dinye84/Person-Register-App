using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PersonRegisterAssignment
{
    /// <summary>
    /// PrintFunctions() represents functions which controls printing information
    /// to console.
    /// </summary>
    internal class PrintFunctions
    {
        internal static void PrintMenuOptions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Menu ***");
            Console.WriteLine("\n(1) Display all suppliers and sort them by name");
            Console.WriteLine("(2) Display all suppliers and sort them by ID");
            Console.WriteLine("(3) Sort suppliers by name and display first five in list.");
            Console.WriteLine("(4) Sort suppliers by ID and display first five in list.");
            Console.WriteLine("(5) Search suppliers name by keyword.");
            Console.WriteLine("(6) Go back to shire (Quit application).");
            Console.Write($"\nEnter an option and press enter to continue: ");
        }
       
        /// <summary>
        /// PrintPersonInfo() assembles headers, lists and prints them to console.
        /// </summary>
        public static void PrintPeople( List<Person> people, int menuChoice)
        {
            //Header
            int x = menuChoice;
            string menuMessage = menuChoice switch
            {
               1 => "\nSorting by name displaying all suppliers.\n",
               2 => "\nSorting by ID displaying all suppliers.\n",
               3 => "\nSorting by name filtering first five suppliers.\n",
               4 => "\nSorting by ID filtering first five suppliers.\n",
               _ => string.Empty
            };
            //FORTSÄTT HÄR. KOLLA VARFÖR MENU CHOICE NUMMER SKRIVS UT EFTER AT MAN SKRIVIT IN KEYWORD I FRITEXTSÖKNING
            Console.WriteLine(menuMessage);

            //Person data
            var peopleCount = people.Count;
            if (peopleCount > 0)
            {
                Console.WriteLine(
                
                $"{"ID",-5}" +
                $"{"Name",-25}" +
                $"{"E-mail",-30}" +
                $"{"Street",-25}" +
                $"{"Post code",-15}" +
                $"{"City",-20}" +
                $"{"Business name",-30}" +
                $"{"Slogan",-50}" +
                "\n"
                );

                for (int i = 0; i < people.Count; i++)
                    Console.WriteLine(
                        $"{people[i].Id,-5}" +
                        $"{people[i].Name,-25}" +
                        $"{people[i].Email,-30}" +
                        $"{people[i].Address.Street,-25}" +
                        $"{people[i].Address.PostCode,-15}" +
                        $"{people[i].Address.City,-20}" +
                        $"{people[i].Company.CompanyName,-30}" +
                        $"{people[i].Company.Slogan,-50}"
                        );
                Console.WriteLine("\n");
            }

            if (peopleCount == 0 && menuChoice <= 6)
            {
                Console.WriteLine("* No result found, please try again.\n");
            }
        }
        internal static void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine(

""""
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
.d$$$$$$$$$$P                                                         `T$b.                                                                      
"""" + 
"\n\n"
);
            Console.WriteLine("Find your local LOTR supplier\n");

        }
    }
}
