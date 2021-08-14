using System;
using System.Linq;
namespace Sum
{
    class Program
    {
        static void Ascending()
        {
            Console.WriteLine("Ascending");
            for(int i=1; i<=100; i++)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static void Descending()
        {
            Console.WriteLine("\nDescending");
            int i = 100;
            while(i>=1)
            {
                Console.Write(i.ToString() + " ");
                i--;
            }
        }
        public static int Sum(int n)
        {
           int sum = 0;
            for(int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Sum_A(int n)
        {
            int sum = 0;
            int i = 0;
            while(i <= n)
            {
                sum = sum + i;
                i++;
            }
            return sum;
        }
        public static int Sum_B(int n)
        {
            int sum = 0;
            return sum = Enumerable.Range(1, n).Sum();
        }
        static void Main(string[] args)
        {
            Ascending();
            Descending();
            int n = 100;
            Console.WriteLine("\nSum : " + Sum(n));
            Console.WriteLine("Sum_A : " + Sum_A(n));
            Console.WriteLine("Sum_B = " + Sum_B(n));
        }
        
    }
}
