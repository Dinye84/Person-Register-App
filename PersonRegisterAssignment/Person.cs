using System.Collections.Specialized;
using System.Text.Json.Serialization;

namespace PersonRegisterAssignment
{
    internal class Person
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
    }
}

