using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumGenerics
{
    class GenericsClass<T> where T : IComparable
    {
        private T[] value;
        public GenericsClass(T[] value)
        {
            this.value = value;
        }
        public T[] Get_Values_Sorted(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T Find_Max_Value(T[] value)
        {
            var max_valueAfter_Sorting = Get_Values_Sorted(value);
            return max_valueAfter_Sorting[value.Length - 1];
        }
        public void Print_Max_Value()
        {
            var max = Find_Max_Value(this.value);
            Console.WriteLine("Maximum Values is "+max);
        }
    }
}
