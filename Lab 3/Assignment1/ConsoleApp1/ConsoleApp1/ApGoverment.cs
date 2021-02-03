using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ApGoverment : CentralGoverment
    {
        public override int calculateTax(string stateName, string commodityName, out int taxRate)
        {
            
            if(commodityName =="gold")
            {
                taxRate = 4;
                Console.WriteLine(price);
               int r= price / taxRate ;
                return r;
            }
            else if(commodityName =="car")
            {
                taxRate = 6;
               
                return (price / taxRate);
            }
            else
            {
                taxRate = 10;
                return price / taxRate;
            }
          
        }
    }
}
