using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonent
    {
        public void Alphabet()
        {
            Console.WriteLine("Please enter any Alphabet");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());
            if (letter ==  'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("Given alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("Given alphabet is Consonent");
            }
        }
    }
}
