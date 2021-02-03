using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class CentralGoverment
    {

        public int price;
        public int Price { get; set; }

        public abstract int calculateTax(string stateName, string commodityName, out int taxRate);

        
    }
}
