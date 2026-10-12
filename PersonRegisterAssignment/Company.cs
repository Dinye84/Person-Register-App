using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterAssignment
{
    public class Company
    {
        private string _companyName = "-";
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _slogan = "-";
        public string Slogan
        {
            get { return _slogan; }
            set { _slogan = value; }
        }
        public Company()
        {
            CompanyName = _companyName;
            Slogan = _slogan;
        }
    }
}
