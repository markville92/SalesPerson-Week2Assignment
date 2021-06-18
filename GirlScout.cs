using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson_Wk2
{
    class GirlScout : Salesperson, ISellable
    {
        private int cookies_boxSold = 0;



        public GirlScout(string firstName, string lastName)
            : base(firstName, lastName)   {  }

        public int cookies_BoxSold
        {
            get
            {
                return cookies_boxSold;
            }

            set
            {
                cookies_boxSold = value;
            }
        }

        public void SalesSpeech()
        {
            Console.WriteLine("I am selling cookies.");
            Console.WriteLine(GetFullName());
        }

        public void MakeSale(int boxSold)
        {
            cookies_boxSold = cookies_boxSold + boxSold;
        }
    }
}
