using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Please enter a four number year");
            double Y = Convert.ToDouble(Console.ReadLine());
            if (Y % 4 == 0 ) 
            {
                Console.WriteLine("Year is Leap year");
            }
            else 
            {
                Console.WriteLine("Year is not Leap year");
            }
        }
    }
}
