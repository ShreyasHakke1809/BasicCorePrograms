using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class  CorePrograms
    {
         public void LEAP_YEAR()
        {
            Console.WriteLine("Please give me four digit");
            int Year =Convert.ToInt32(Console.ReadLine());

            if((Year % 400 == 0) || (Year % 4 == 0 && Year % 100 != 0))
            {
                Console.WriteLine("Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is Not Leap Year");
            }
        }

    }
}
