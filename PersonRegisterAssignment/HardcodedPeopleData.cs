using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PersonRegisterAssignment
{
    public class HardcodedPeopleData
    {
        public List<Person> hardcodedListOfPeople = new List<Person>();

        public HardcodedPeopleData()
        {
            hardcodedListOfPeople.Add(person1);
            hardcodedListOfPeople.Add(person2);
            hardcodedListOfPeople.Add(person3);
        }

        //Hardcoded demo objects
        //Note, for transparacy: first instance is manually made,
        //other 9 are ai-generated for convinience.
        Person person1 = new()
        {
            Id = 1,
            Name = "Andreas Karlsson",
            Email = "andreas@andreas.com",
            Address = "Testvägen 11b, 70221 Stockholm",
            Company = "Skofabriken",
            Slogan = "Vi gör bättre skor",

        };
        Person person2 = new()
        {
            Id = 2,
            Name = "Bertil Svennson",
            Email = "bertil@bertil.com",
            Address = "Testvägen 12b, 70222 Stockholm",
            Company = "Nyckelfabriken",
            Slogan = "Vi gör bättre nycklar",

        };

        Person person3 = new()
        {
            Id = 3,
            Name = "Cecilia Larsson",
            Email = "cecilia@cecilia.com",
            Address = "Testvägen 13b, 70223 Stockholm",
            Company = "Tröjfabriken",
            Slogan = "Vi gör bättre tröjor",
        };

        Person person4 = new()
        {
            Id = 4,
            Name = "David Davidsson",
            Email = "david@david.com",
            Address = "Testvägen 14b, 70224 Stockholm",
            Company = "Cykelfabriken",
            Slogan = "Vi gör bättre cyklar",
        };

        Person person5 = new()
        {
            Id = 5,
            Name = "Elin Elinsson",
            Email = "elin@elin.com",
            Address = "Testvägen 15b, 70225 Stockholm",
            Company = "Bokfabriken",
            Slogan = "Vi gör bättre böcker",
        };

        Person person6 = new()
        {
            Id = 6,
            Name = "Fredrik Fredirksson",
            Email = "fredrik@fredrik.com",
            Address = "Testvägen 16b, 70226 Stockholm",
            Company = "Lampfabriken",
            Slogan = "Vi gör bättre lampor",
        };

        Person person7 = new()
        {
            Id = 7,
            Name = "Greta Svensson",
            Email = "greta@greta.com",
            Address = "Testvägen 17b, 70227 Stockholm",
            Company = "Stolfabriken",
            Slogan = "Vi gör bättre stolar",
        };

        Person person8 = new()
        {
            Id = 8,
            Name = "Henrik Henriksson",
            Email = "henrik@henrik.com",
            Address = "Testvägen 18b, 70228 Stockholm",
            Company = "Bordfabriken",
            Slogan = "Vi gör bättre bord",
        };

        Person person9 = new Person
        {
            Id = 9,
            Name = "Isabella Jönsson",
            Email = "isabella@isabella.com",
            Address = "Testvägen 19b, 70229 Stockholm",
            Company = "Väskfabriken",
            Slogan = "Vi gör bättre väskor",
        };

        Person person10 = new Person
        {
            Id = 10,
            Name = "Johan Karlsson",
            Email = "johan@johan.com",
            Address = "Testvägen 20b, 70230 Stockholm",
            Company = "Mössfabriken",
            Slogan = "Vi gör bättre mössor",
        };

    }

}
