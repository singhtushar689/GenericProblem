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
            max.MaxValue(10.5f, 8.9f, 9.0f);
            max.MaxValue("Sachin", "Tushar", "Rohan");
            Console.ReadLine();
        }
    }
}
