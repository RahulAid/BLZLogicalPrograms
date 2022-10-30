using System;
using System.Diagnostics;
using System.Threading;
class StopwatchProgram
{
    static void Main()
    {
         Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of coupons to be generated : ");
            int NoOfCoupons = Convert.ToInt32(Console.ReadLine());
            int lengthOfCoupon = 8;

            List<string> generatedCoupons = new List<string>();
            char[] keys = "99999999".ToCharArray();


            Console.WriteLine("Coupons Generated : ");
            while (generatedCoupons.Count < NoOfCoupons)
            {
                var coupon = GenerateCoupon(keys, lengthOfCoupon);
                if (!generatedCoupons.Contains(coupon))
                {
                    generatedCoupons.Add(coupon);
                    Console.WriteLine("\t[#{0}] {1}", generatedCoupons.Count, coupon);
                }
            }
            Console.WriteLine("done");
            Console.ReadLine();
        }

        string GenerateCoupon(char[] keys, int lengthOfCoupon)
        {
            return Enumerable
                .Range(1, lengthOfCoupon)
                .Select(k => keys[random.Next(0, keys.Length - 1)])
                .Aggregate("", (e, c) => e + c);
        }
    }
}
