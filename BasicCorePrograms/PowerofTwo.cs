using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerofTwo
    {
        public void PowerofTwoTable() 
        {
            int power;
            Console.WriteLine("Please enter value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                power = Convert.ToInt32(Math.Pow( 2, i ));
                Console.WriteLine("2^" + i + " : " + power);
            }
        }
    }
}
