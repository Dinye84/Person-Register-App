using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PersonRegisterAssignment
{
    internal class Address
    {
        private string _street = "";
        internal string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        private int _postCode = 0;
        internal int PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

        private string _city = "";
        internal string City
        {
            get { return _city; }
            set { _city = value; }
        }
        internal Address()
        {
            Street = _street;
            PostCode = _postCode;
            City = _city;
        }
    }
}
