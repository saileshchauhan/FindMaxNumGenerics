using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumGenerics
{
    class GenericsClass<T> where T : IComparable
    {
        private T first, second, third;
        public GenericsClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T To_Find_Max_Using_Generics_Class()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                throw new Exception("FirstNumber,ThirdNumber,SecondNumber are Equal");
            }

        }




    }
}
