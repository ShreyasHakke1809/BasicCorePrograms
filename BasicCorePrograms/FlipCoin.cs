using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public void HeadTail()
        {
            int head = 0;
            int tail = 1;
            double headPercentage , tailPercentage;
            int noOfFlips = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();         
            for (int i = 0; i < noOfFlips; i++)
            {
                int flip = random.Next(0, 2);
                if (flip == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
             headPercentage = (double) head / noOfFlips * 100;
             tailPercentage = (double) tail / noOfFlips * 100;

              Console.WriteLine($"Heads percentage: {head} {headPercentage}");
              Console.WriteLine($"Tails Percentage: {tail} {tailPercentage}");
           //Console.WriteLine("Percentage of Tails : {0} \nPercentage of Heads: {1}", tailPercentage, headPercentage);
        }
    }
}
