using System;

namespace square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Number: ");
            var num = Convert.ToInt32(Console.ReadLine());

            var squar = new square().sqrt(num);
            Console.WriteLine(squar);
        }
    }
}
public class square
{
    public int sqrt(int n)
    {
        return n * n;
    }
}