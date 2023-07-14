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
            double HarmonicNum = 0, reciprocal;
            Console.WriteLine("Please enter a number to calculate Nth Harmonic value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    reciprocal = (double)1 / i;
                    HarmonicNum = HarmonicNum + reciprocal;
                    Console.Write("1/" + i + " + ");
                }
                Console.WriteLine("\nNth Harmonic value is : " + HarmonicNum);
            }
            else
                Console.WriteLine("Please enter a number greater than zero");
        }
    }
}
