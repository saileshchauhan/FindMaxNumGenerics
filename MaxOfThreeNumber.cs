﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumGenerics
{
 public class MaxOfThreeNumber
    {
        public int Max_Of_Three_Integers(int firstNumber,int secondNumber,int thirdNumber)
        {
            if (firstNumber.CompareTo(thirdNumber)>0 && firstNumber.CompareTo(thirdNumber)>0)
            {
                return firstNumber;
            }
            if(secondNumber.CompareTo(thirdNumber)>0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if(thirdNumber.CompareTo(firstNumber)>0 && thirdNumber.CompareTo(secondNumber) > 0)
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