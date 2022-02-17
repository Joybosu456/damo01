using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the fact value :");
            int factNum = Convert.ToInt32(Console.ReadLine());
            //5!=1*2*3*4*5
            int factResult = 1;

            //for(int i=1;i<=factNum;i++)
            //{
                //factResult = factResult * i;
            //}
            for (int i=factNum;i>=1;i--)
            {
                factResult = factResult * i;
            }
            Console.WriteLine("{0} ! is {1} ", factNum, factResult);
        }
    }
}