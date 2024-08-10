using System;
using System.Numerics;

namespace HelloWorld
{
    class Person
    {
        static void Main() {

            //exercise 1
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(exercise1(n));

            //exercise 2
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(exercise2(n));

            //exercise 3
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(exercise3(n));

            //exercise 4
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(exercise4(n));

            //exercise 5
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(exercise5(n));

            //exercise 6
            /*Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(exercise6(n));*/

            //exercise 7
            /*Console.Write("Enter n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise7(n));*/

            //exercise 8
            /*Console.Write("Enter n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise8(n));*/

            //exercise 9
            /*Console.Write("Enter n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise9(n));*/

            //exercise 10
            Console.Write("Enter a: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise10(a,b));

        }

        //exercise 1
        static int exercise1(int n)
        {
            int total = 0;
            for (int i = 0; i <= n; i++) {
                total += i;
            }

            return total;
        }

        //exercise 2:
        static double exercise2(int n)
        {
            double total = 0;
            for(int i = 0; i <= n; i++)
            {
                total += Math.Pow(i, 2);
            }
            return total;
        }

        //exercise 3:
        static double exercise3(int n) {
            double total = 0;
            for (int i = 1; i <= n; i++) {
                total += (1.0/i);
            }

            return total;
        }

        //exercise 4: 
        static double exercise4(int n)
        {
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += (1.0 / (2 * i));
            }

            return total;
        }

        //exercise 5: 
        static double exercise5(int n)
        {
            double total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += (1.0 / ((2 * i)+1) );
            }

            return total;
        }
        //exercise 6:

        static double exercise6(int n)
        {
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += 1.0 / (i * (i + 1));
            }

            return total;
        }

        //exercise 7
        static double exercise7(int n)
        {
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += (double)i / (i + 1);
            }

            return total;
        }

        //exercise 8
        static double exercise8(int n)
        {
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += (double)(i * 2 + 1) / (2*i + 2);
            }

            return total;
        }

        //exercise 9
        static double exercise9(int n)
        {
            double total = 1;
            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }

            return total;
        }

        //exercise 10
        static double exercise10(int a, int b)
        {
            double total = Math.Pow(a,b);

            return total;
        }
    }
}