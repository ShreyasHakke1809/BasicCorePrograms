using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public void ComputeQutientAndRemainder()
        {
            int quotient, remainder;
            Console.WriteLine("Enter the value of divident: ");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quotient = divident / divisor;
            remainder = divident % divisor;

            Console.WriteLine("dividend {0}: , divisor {1}", divident, divisor);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
