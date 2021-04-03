using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a = 0, b = 1, c;

            for(int i=0;i<5;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
