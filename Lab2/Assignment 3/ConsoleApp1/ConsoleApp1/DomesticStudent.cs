using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class DomesticStudent
    {
        public int courseFee;
       public DomesticStudent(int courseFee)
        {
            this.courseFee = courseFee;
        }
        public virtual void getScholorShipAmount()
        {

            double r = (courseFee / 10)*3;
                      Console.WriteLine("Domestic Student scholorShipAmount :" + r );
            Console.ReadLine();

        }

    }
}
