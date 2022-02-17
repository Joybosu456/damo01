using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    internal class Sub
    {
        public static void SubTwoNum()
        {
            Console.WriteLine("Enter fast number a= :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter secound number b=:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a - b;
            Console.WriteLine(c);

        }
    }
}
