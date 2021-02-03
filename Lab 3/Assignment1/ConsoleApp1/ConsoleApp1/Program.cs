using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ApGoverment apGoverment = new ApGoverment();
            MaharashtraGoverment maharashtraGoverment = new MaharashtraGoverment();
            Console.WriteLine("Enter your gold price:");
            apGoverment.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your car price:");
            apGoverment.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your chocaloate price:");
            apGoverment.price = Convert.ToInt32(Console.ReadLine());

            int tax = apGoverment.calculateTax("ApGoverment", "gold",out int taxRate);
            int tax1 = maharashtraGoverment.calculateTax("maharashtra", "car", out taxRate);
            Console.WriteLine("The gold tax of AP goverment :"+ tax);
            Console.WriteLine("the gold tax of maharashtra :" + tax1);
            Console.ReadLine();
           
        }
    }
}
