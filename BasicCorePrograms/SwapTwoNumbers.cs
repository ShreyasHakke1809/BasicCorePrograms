using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        public void SwapNumbers()
        {
            Console.WriteLine("Enter a first number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int B = Convert.ToInt32(Console.ReadLine());            
            A = A + B; 
            B = A - B; 
            A = A - B;  
            Console.WriteLine("After Swaping First Number is {0}, Second Number is {1}:", A , B);
        }
    }
}
