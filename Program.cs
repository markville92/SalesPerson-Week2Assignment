using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson_Wk2
{
    class Program
    {
        static void Main(string[] args)
        {

            // House sold for person
            RealEstateSalesperson realObj = new RealEstateSalesperson(5, "John", "Doe");
            realObj.SalesSpeech();
            realObj.MakeSale(1000);
            realObj.MakeSale(2000);
            Console.WriteLine("Total value of houses sold = " + realObj.TotalValue);
            Console.WriteLine("Total commission  = " + realObj.TotalCommission);
            Console.WriteLine("");

            //Girl Scout
            GirlScout girlObj = new GirlScout("Jane", "Doe");
            girlObj.SalesSpeech();
            girlObj.MakeSale(5);
            girlObj.MakeSale(7);
            Console.WriteLine("Total boxes sold: " + girlObj.cookies_BoxSold);
            




        }
    }
}
