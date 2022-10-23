using System.Diagnostics;

namespace BLZLogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be Reversed");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int rev = 0;
            while (n != 0)
            {
                int d = n % 10;
                rev = rev * 10 + d;
                n /= 10;
            }
            Console.WriteLine("Reverse of " + num + " is " + rev);
        }
    }
}