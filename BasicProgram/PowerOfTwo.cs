using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PowerOfTwo
    {
        public void PowerOf2()
        {
            int POWER;
            Console.WriteLine("Please give Number for N:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
             POWER =Convert.ToInt32(Math.Pow(2, i));
             Console.WriteLine("2^" + i + ":"  + POWER);
            }           
        }
    }
}
