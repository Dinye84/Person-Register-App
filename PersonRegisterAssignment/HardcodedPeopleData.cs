using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PersonRegisterAssignment
{
    internal class HardcodedPeopleData : IPeopleDataSources
    {
        private List<Person> _hardcodedPeople = [];
        public List<Person> GetPeople()
        {
            List<Person> people = _hardcodedPeople;

            return people;
        }
        
        internal HardcodedPeopleData()
        {
            _hardcodedPeople.Add(new()
            {
                Id = 7,
                Name = "Gandalf the Grey",
                Email = "gandalf@istari.me",
                Address = new Address
                {
                    Street = "Bag End Lane 3",
                    PostCode = 10021,
                    City = "Hobbiton"
                },
                Company = new Company
                {
                    CompanyName = "Gandalf's Fireworks",
                    Slogan = "A little magic goes a long way."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 3,
                Name = "Legolas Greenleaf",
                Email = "legolas@woodlandrealm.me",
                Address = new Address
                {
                    Street = "Forest River Road 18",
                    PostCode = 30512,
                    City = "Woodland Realm"
                },
                Company = new Company
                {
                    CompanyName = "Greenleaf Archery",
                    Slogan = "Every arrow finds its mark."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 10,
                Name = "Samwise Gamgee",
                Email = "sam@shire.me",
                Address = new Address
                {
                    Street = "Bagshot Row 3",
                    PostCode = 10022,
                    City = "Hobbiton"
                },
                Company = new Company
                {
                    CompanyName = "Sam's Gardening Services",
                    Slogan = "Helping things grow, even in the darkest places."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 1,
                Name = "Aragorn Elessar",
                Email = "aragorn@gondor.me",
                Address = new Address
                {
                    Street = "King's Court 1",
                    PostCode = 70001,
                    City = "Minas Tirith"
                },
                Company = new Company
                {
                    CompanyName = "Strider's Wilderness Guides",
                    Slogan = "Every journey deserves a trusted guide."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 8,
                Name = "Gimli, Son of Glóin",
                Email = "gimli@erebor.me",
                Address = new Address
                {
                    Street = "Stone Hall 24",
                    PostCode = 40510,
                    City = "Erebor"
                },
                Company = new Company
                {
                    CompanyName = "Gimli's Mining Company",
                    Slogan = "Nobody tosses a dwarf."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 5,
                Name = "Frodo Baggins",
                Email = "frodo@shire.me",
                Address = new Address
                {
                    Street = "Bag End 1",
                    PostCode = 10020,
                    City = "Hobbiton"
                },
                Company = new Company
                {
                    CompanyName = "Frodo's Courier Service",
                    Slogan = "No delivery is too important to carry."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 2,
                Name = "Éowyn of Rohan",
                Email = "eowyn@rohan.me",
                Address = new Address
                {
                    Street = "Golden Hall Road 7",
                    PostCode = 60014,
                    City = "Edoras"
                },
                Company = new Company
                {
                    CompanyName = "Éowyn's Riding Academy",
                    Slogan = "Ride with courage. Fear no challenge."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 9,
                Name = "Bilbo Baggins",
                Email = "bilbo@shire.me",
                Address = new Address
                {
                    Street = "Bag End 2",
                    PostCode = 10020,
                    City = "Hobbiton"
                },
                Company = new Company
                {
                    CompanyName = "Bilbo's Adventure Tours",
                    Slogan = "Your next unexpected journey starts here."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 4,
                Name = "Arwen Undómiel",
                Email = "arwen@rivendell.me",
                Address = new Address
                {
                    Street = "Last Homely House 8",
                    PostCode = 30015,
                    City = "Rivendell"
                },
                Company = new Company
                {
                    CompanyName = "Arwen's Fine Jewellery",
                    Slogan = "Timeless beauty, crafted to last."
                }
            }
            );

            _hardcodedPeople.Add(new()
            {
                Id = 6,
                Name = "Peregrin Took",
                Email = "pippin@shire.me",
                Address = new Address
                {
                    Street = "Great Smials 11",
                    PostCode = 10035,
                    City = "Tuckborough"
                },
                Company = new Company
                {
                    CompanyName = "Pippin's Catering",
                    Slogan = "Breakfast, second breakfast, and everything in between."
                }
            }
            );
        }
    }
}