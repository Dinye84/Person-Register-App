using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterAssignment
{
    /// <summary>
    /// PrintMenuOptions() represents functions which controls printing information
    /// to console.
    /// </summary>
    internal class PrintFunctions
    {
        internal static void PrintMenuOptions()
        {  
            Console.WriteLine("*** Menu ***");
            Console.WriteLine("\n(1) Display all people and sort them by ID");
            Console.WriteLine("(2) Sort people by ID and display first five in list.");
            Console.WriteLine("(3) Display all people and sort them by name");
            Console.WriteLine("(4) Sort people by name and display first five in list.");
            Console.WriteLine("(5) Search people name by keyword.");
            Console.WriteLine("(6) Go back to shire (Quit application).");
            Console.Write($"\nEnter an option and press enter to continue: ");
        }

        /// <summary>
        /// PrintPeople() structures headers, lists and other messages and prints them to console.
        /// </summary>
        public static void PrintPeople( List<Person> people, int menuChoice)
        {
            string menuMessage = menuChoice switch
            {
               1 => "\nSorting by ID displaying all people.\n",
               2 => "\nSorting by ID filtering first five people.\n",
               3 => "\nSorting by name displaying all people.\n",
               4 => "\nSorting by name filtering first five people.\n",
                _ => string.Empty
            };
            Console.WriteLine(menuMessage);

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
                $"{"Company name",-35}" +
                $"{"Slogan",-50}" +
                "\n");

                for (int i = 0; i < people.Count; i++)
                    Console.WriteLine(
                        $"{people[i].Id,-5}" +
                        $"{people[i].Name,-25}" +
                        $"{people[i].Email,-30}" +
                        $"{people[i].Address.Street,-25}" +
                        $"{people[i].Address.PostCode,-15}" +
                        $"{people[i].Address.City,-20}" +
                        $"{people[i].Company.CompanyName,-35}" +
                        $"{people[i].Company.Slogan,-50}");

                Console.WriteLine("\n");
            }

            if (peopleCount == 0 && menuChoice <= 6)
            {
                Console.WriteLine("* No result found, please try again.\n");
            }
        }

        internal static void GetHelpMessage()
        {
            Console.WriteLine(
                    "\nusage: list [--top5] [--sort] [--search <keyword>] [--help]\n\n" +
                    "These are the common LOTR register commands used in various situations:\n" +
                    "display lists\n" +
                    "\tlist\t\t sorts list by ID.\n" +
                    "\t--top5\t\t sorts list by ID and displays first five people.\n" +
                    "\t--sort\t\t sorts list by name.\n" +
                    "\t--sort --top5\t\t sorts list by name and displays the first five people.\n" +
                    "\t--search\t\t searches register names and displays all people containing the keyword"
                    );
        }

        internal static void GetUnknownCommandMessage()
        {
            Console.WriteLine(
                "\nUnknown option or invalid command.\n" +
                "usage: list [--top5] [--sort] [--search <keyword>] [--help]\n\n"
                );
        }

        internal static void GetInvalidDataSourceMessage()
        {
            Console.WriteLine($"Invalid data source selection.\n" +
                        $"To select a data source, add the value \"1\" or \"2\" in " +
                        $"Main() / RegisterFunctions.SelectDataSource()\n");
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
