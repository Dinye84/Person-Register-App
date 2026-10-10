using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PersonRegisterAssignment
{
    public class PrintFunctions
    {
        public static void GetMenu()
        {
            var msg = GetMessage();
            int menuOptionCount = 6;
            for (int i = 0; i < menuOptionCount; i++  )
            {
                Console.WriteLine(msg.ElementAt(i).Value);
            }
            Print.Message(msg["OptionSelector"]);
        }


        
        public static Dictionary<string, string> GetMessage()
        {
            Dictionary<string, string> msg = new()
        {
            {"AllSortedId", "\r\n(1) Display all suppliers and sort them by ID" },
            {"AllSortedName", "(2) Display all suppliers and sort them by Name" },
            {"SortIDFilterFive", "(3) Sort suppliers by ID and display first five in list." },
            {"SortNameFilterFive", "(4) Sort suppliers by Name and display first five in list." },
            {"SearchKeyword", "(5) Search for suppliers by keyword." },
            {"QuitApp", "(6) Go back to shire (Quit application)." },
            {"ErrorMsg1", "Error. Please select an option between 1-6." },
            {"ErrorMsg2", "Error. Please try again." },
            {"Title", $"Find your local LOTR supplier\r\n"},
            {"Divider", "******************************" },
            {"OptionSelector", "\r\nWrite an option and press enter:" }
            
        };

            return msg;
            
            
        }
        public static void PrintInfo(Menu menu)
        {
            var msg = GetMessage();
            int menuChoice = menu.MenuChoice;
            string message = menuChoice switch
            {
                1 => msg["AllSortedId"],
                2 => msg["AllSortedName"],
                3 => msg["SortIDFilterFive"],
                4 => msg["SortNameFilterFive"],
                5 => msg["SearchKeyword"],
                6 => msg["QuitApp"],
                7 => msg["ErrorMsg1"],
                _ => msg["ErrorMsg2"]
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
                    $"{combinedPeopleList[i].Company.Slogan,-50}"
                    );
        }

        public static void GetBanner()
        {
            Console.WriteLine("\r\n");
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
"\r\n\r\n"
);

        }
    }
}
