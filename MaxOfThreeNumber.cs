using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumGenerics
{
    public class MaxOfThreeNumber
    {
        
        public static T To_Find_Max_Using_Generics<T>(T firstNumber,T secondNumber,T thirdNumber) where T : IComparable
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            else
            {
                throw new Exception("FirstNumber,ThirdNumber,SecondNumber are Equal");
            }
        }
    }
}
