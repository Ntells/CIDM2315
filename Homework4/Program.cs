using System;
//Q1
namespace main
{
    class main
    {
        static void Main(string[] args)
        {

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int largest_number = largest(a, b);
            Console.WriteLine("The largest number is: " + largest_number);
            Console.WriteLine();
            Console.Write("N is: " );
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write("shape is: ");
            string v=Console.ReadLine();
            Shape(n, v);
        }

        static int largest(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Shape(int n, string v)
        {

            if (v == "Left")
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (v == "Right")
            {
                for (int i = n-1; i >= 0; i--)
                {
                    Console.WriteLine(new string(' ', i)+new string('*', n-i));
                }
            }
        }

    }
}
