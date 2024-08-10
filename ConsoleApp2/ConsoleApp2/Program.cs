using System;
using System.Numerics;

namespace HelloWorld
{
    class Person
    {
        static void Main()
        {

            //exercise 11
            Console.Write("Enter a: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise10(a, b));

        }

        //exercise 1
        static int exercise1(int n)
        {
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += i;
            }

            return total;
        }
    }
}