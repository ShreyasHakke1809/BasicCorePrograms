using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void GetHarmonicNumber()
        {
            double sum = 0;
            Console.WriteLine("Please enter a number to calculate Nth Harmonic value");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum +=(double)1 / i;
            }
            Console.WriteLine("Sum is : {0}", sum);
        }
    }
}
