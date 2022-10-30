using System.Diagnostics;

namespace BLZLogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Nth term of the Fibonacci Series : ");
            int N = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("The Fibonacci Series for "+N+" terms are :");
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < (N - 2); i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();

        
        }
    }
}