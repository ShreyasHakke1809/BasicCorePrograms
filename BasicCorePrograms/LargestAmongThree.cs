using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestAmongThree
    {
        public void LargestNumber()
        {
            Console.WriteLine("Please enter three numbers:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine(A + " is greatest among three");
            }
            else if (B > A && B > C)
            {
                Console.WriteLine(B + " is greatest among three");
            }
            else
            {
                Console.WriteLine(C + " is greatest among three");
            }
        }
    }
}
