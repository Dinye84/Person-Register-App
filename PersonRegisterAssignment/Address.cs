using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace PersonRegisterAssignment
{
    public class Address
    {
        private string _street = "";
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        private int _postCode = 0;
        public int PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

        private string _city = "";
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public Address()
        {
            Street = _street;
            PostCode = _postCode;
            City = _city;
        }
    }
}
