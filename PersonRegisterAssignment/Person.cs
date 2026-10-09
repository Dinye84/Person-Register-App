using System.Collections.Specialized;

namespace PersonRegisterAssignment
{
    public class Person

    {
        private int _id = 0;
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        private string _name = "-";
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        private string _email = "-";
        public string Email 
        { 
            get { return _email; } 
            set { _email = value; } 
        }
        public Address Address { get; set; } = new();
        public Company Company { get; set; } = new();
       

        public Person()
        {
            Id = _id;
            Name = _name;
            Email = _email;
           
        }

        /// <summary>
        /// Combines several data sources and combines them to one list
        /// </summary>



        public static List<Person> GetPeople()
        {
            //External data sources will be set here.
            HardcodedPeopleData hardcodedPeopleData = new();
            List<Person> combinedPeople = hardcodedPeopleData.hardcodedPeopleDataList;
            

            return combinedPeople;
        }

        //public static List<Person> GetExternalDataSource()
  
    }
}

