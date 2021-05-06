using System;

namespace FindMaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestInteger = MaxOfThreeNumber.To_Find_Max_Using_Generics<int>(6, 7, 4);
            Console.WriteLine(largestInteger);

            string longestString = MaxOfThreeNumber.To_Find_Max_Using_Generics<string>("zebra","lion","tiger");
            Console.WriteLine(longestString);

            double largestFloat = MaxOfThreeNumber.To_Find_Max_Using_Generics<double>(2.4,5.789,4.56);
            Console.WriteLine(largestFloat);



        }
    }
}
