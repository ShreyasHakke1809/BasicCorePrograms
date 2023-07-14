namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the basic core programs\nChoose a program to run :");
            Console.WriteLine("\n 1. Flip coin \n 2. Leap year \n 3. Power of 2\n 4. Harmonic Number \n " +
                "5. Prime Factors \n 6. Compute Quotient and Remainder \n 7. Swap Two Numbers \n " +
                "8. Check Whether a Number is Even or Odd \n 9. Check Whether an Alphabet is Vowel or Consonant \n 10.Find the largest among three");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.HeadTail();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerofTwo powerOfTwo = new PowerofTwo();
                    powerOfTwo.PowerofTwoTable();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.GetHarmonicNumber();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.ComputeQutientAndRemainder();
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.SwapNumbers();
                    break;
                case 8:
                    EvenorOdd evenorOdd = new EvenorOdd();
                    evenorOdd.CheckEvenOdd();
                    break;
                case 9:
                    VowelOrConsonent vowelOrConsonent = new VowelOrConsonent();
                    vowelOrConsonent.Alphabet();
                    break;
                case 10:
                    LargestAmongThree largestAmongThree = new LargestAmongThree();
                    largestAmongThree.LargestNumber();
                    break;
                default:
                    Console.WriteLine("Please enter right number");
                    break;
            }
        }
    }
}