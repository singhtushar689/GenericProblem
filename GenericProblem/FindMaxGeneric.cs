using System;
using System.Collections.Generic;
namespace GenericProblem
{
    public class FindMaxGeneric<T> where T : IComparable
    {
        public T Max(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                return first;
            if (second.CompareTo(third) >= 0 && second.CompareTo(third) >= 0)
                return second;
            if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
                return third;
            return first;
        }
    }
}