using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Student
    {
       
      static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your courseFee :");
            int fees = Convert.ToInt32(Console.ReadLine());
            DomesticStudent student1 = new DomesticStudent(fees);
            DomesticStudent student = new ForeignStudent(fees);
            student.getScholorShipAmount();







        }
    }
}
