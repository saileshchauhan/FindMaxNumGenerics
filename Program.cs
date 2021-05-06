using System;

namespace FindMaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxOfThreeNumber integer = new MaxOfThreeNumber();
            int maximumInteger=integer.Max_Of_Three_Integers(23,45,78);
            Console.WriteLine("Maximum Integer is "+maximumInteger);

            double maximumDecimal = MaxOfThreeNumber.Max_Of_Three_Floats(4.27,5.6,7.89);
            Console.WriteLine("Maximum decimal number is "+maximumDecimal);

            string longestString = MaxOfThreeNumber.Max_Of_Three_String("zebra","tiger","elephant");
            Console.WriteLine("Longest string Length is  "+longestString);
        }
    }
}
