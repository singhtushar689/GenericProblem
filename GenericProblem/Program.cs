using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMaxInteger max = new FindMaxInteger();
            max.MaxValue(10, 35, 31);          
            Console.ReadLine();
            FindMaxGeneric<int> maxGeneric = new FindMaxGeneric<int>();
            maxGeneric.Max(23, 34, 21);

        }
    }
}
