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
        }
    }
}
