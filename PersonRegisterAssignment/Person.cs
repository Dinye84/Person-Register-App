using System.Collections.Specialized;

namespace PersonRegisterAssignment
{
    internal class Person
    {
        private int _id = 0;
        internal int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        private string _name = "-";
        internal string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        private string _email = "-";
        internal string Email 
        { 
            get { return _email; } 
            set { _email = value; } 
        }
        internal Address Address { get; set; } = new();
        internal Company Company { get; set; } = new();
        internal Person()
        {
            Id = _id;
            Name = _name;
            Email = _email;
        }
    }
}

