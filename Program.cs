using System;

namespace FindMaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //int largestInteger = MaxOfThreeNumber.To_Find_Max_Using_Generics<int>(6, 7, 4);
            //Console.WriteLine(largestInteger);

            //string longestString = MaxOfThreeNumber.To_Find_Max_Using_Generics<string>("zebra","lion","tiger");
            //Console.WriteLine(longestString);

            //double largestFloat = MaxOfThreeNumber.To_Find_Max_Using_Generics<double>(2.4,5.789,4.56);
            //Console.WriteLine(largestFloat);

            //GenericsClass<int> maxInteger = new GenericsClass<int>(3, 5, 7);
            //int maximumOfThreeIntegers = maxInteger.To_Find_Max_Using_Generics_Class();
            //Console.WriteLine("Max of three Integers  "+maximumOfThreeIntegers);

            //GenericsClass<double> maxdecimal = new GenericsClass<double>(5.6, 7.09, 8.1);
            //double maximumOfThreeDecimals = maxdecimal.To_Find_Max_Using_Generics_Class();
            //Console.WriteLine("Max of three Decimal Number  "+maximumOfThreeDecimals);

            //GenericsClass<string> longString = new GenericsClass<string>("BridzeLabs", "Infosys", "wipro");
            //string longestString = longString.To_Find_Max_Using_Generics_Class();
            //Console.WriteLine("Longest String is "+longestString);

            int[] value = {24,678,34,56,345};
            new GenericsClass<int>(value).Print_Max_Value();

        }
    }
}
