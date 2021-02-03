using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ForeignStudent:DomesticStudent
    {

        public ForeignStudent(int courseFee):base(courseFee)
        {
            this.courseFee = courseFee;
        }
        public override void  getScholorShipAmount()
        {
            base.getScholorShipAmount();
            double r = courseFee / 10;
            Console.WriteLine("scholorShip Amount for foreign Student " + (r));
            Console.ReadLine();
            
        }

    }
}
