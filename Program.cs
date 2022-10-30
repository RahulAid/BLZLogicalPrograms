using System.Diagnostics;

namespace BLZLogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine(n + " is a Perfect Number");

            }
            else
            {
                Console.WriteLine(n + " is not a Perfect Number");

            }
        }
    }
}