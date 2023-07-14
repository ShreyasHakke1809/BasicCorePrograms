using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Please enter a number to find prime factors");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i + " ");
                    N = N / i;
                }
            }
            if (N > 2)
            {
                Console.WriteLine(N);
            }
        }
    }
}
