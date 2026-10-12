using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterAssignment
{
    internal class Company
    {
        private string _companyName = "-";
        internal string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _slogan = "-";
        internal string Slogan
        {
            get { return _slogan; }
            set { _slogan = value; }
        }
        internal Company()
        {
            CompanyName = _companyName;
            Slogan = _slogan;
        }
    }
}
