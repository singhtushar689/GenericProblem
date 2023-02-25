using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class FindMaxInteger
    {
        public void MaxValue(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine($"{first} is greater");
            if (second.CompareTo(third) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine($"{second} is greater");
            if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
                Console.WriteLine($"{third} is greater");
        }
    }
}
