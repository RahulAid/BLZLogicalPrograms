using System.Diagnostics;

namespace BLZLogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int count = 0;
            for (int a = 2; a <= n; a++)
            {

                if(n % a == 0 )
                {
                    count += 1;
                }
            }
            if (count > 1)
            {
                Console.WriteLine(num+" is not a Prime Number");
            }
            else
                Console.WriteLine(num+" is a Prime Number");
        }
    }
}