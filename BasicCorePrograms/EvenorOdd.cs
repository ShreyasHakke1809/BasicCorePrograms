using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenorOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Please give me number");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine("Given number is Even");
            }
            else
            {
                Console.WriteLine("Given number is Odd");
            }
        }
    }
}
