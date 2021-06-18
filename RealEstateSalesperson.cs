using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson_Wk2
{
    class RealEstateSalesperson : Salesperson, ISellable
    {
        private double totalValue = 0.00;
        private double totalCommission = 0.00;
        private double commissionRate = 0;

        

        public RealEstateSalesperson(double commRate, string firstName, string lastName) 
            : base(firstName, lastName)
        {
            
            commissionRate = commRate;
        }

        public double TotalValue
        {
            get
            {
                return totalValue;
            }

            set
            {
               totalValue = value;
            }
        }

        public double TotalCommission
        {
            get
            {
                return totalCommission;
            }

            set
            {
                totalCommission = value;
            }
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }

            set
            {
                commissionRate = value;
            }
        }



        public void SalesSpeech ()
        {
            Console.WriteLine("I am selling this house.");
            Console.WriteLine(GetFullName());
        }

        public void MakeSale(int houseValue)
        {
            totalValue = totalValue + houseValue;
            totalCommission = totalCommission + houseValue * commissionRate / 100;
        }
           

    }
}
