using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaharashtraGoverment : CentralGoverment
    {
        public override int calculateTax(string stateName, string commodityName, out int taxRate)
        {
             
            if(commodityName=="gold")
            {
                taxRate = 3;
                return price % taxRate;
            }
            else if(commodityName == "car")
            {
                taxRate = 7;
                return price % taxRate;
            }
            else
            {
                taxRate = 9;
                return price % taxRate;
            }
           
        }
    }
}
