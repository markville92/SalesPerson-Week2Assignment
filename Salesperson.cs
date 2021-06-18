using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson_Wk2
{
    abstract partial class Salesperson
    {
        private string firstName;
        private string lastName;

        public Salesperson(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }


    }
}
