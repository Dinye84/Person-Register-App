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
        private string _address = "-";
        public string Address 
        { 
            get { return _address; } 
            set { _address = value; } 
        }
        private int _postCode = 0;
        public int PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }
        private string _company = "-";
        public string Company 
        { 
            get { return _company; } 
            set { _company = value; } 
        }
        private string _slogan = "-";
        public string Slogan 
        { 
            get { return _slogan; } 
            set { _slogan = value; } 
        }

        public Person()
        {
            _id = Id;
            _name = Name;
            _email = Email;
            _address = Address;
            _postCode = PostCode;
            _company = Company;
            _slogan = Slogan;
        }

        /// <summary>
        /// Combines several data sources and combines them to one list
        /// </summary>



        public static List<Person> GetPeople()
        {
            //External data sources will be set here.
            HardcodedPeopleData hardcodedPeopleData = new();
            
            List<Person> combinedPeopleDataList = hardcodedPeopleData.hardcodedPeopleDataList;
            

            return combinedPeopleDataList;
        }
  
    }
}

