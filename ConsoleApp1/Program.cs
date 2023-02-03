using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int fib(int n)
        {
            int x = 1;
            int y = 0;
            int ans = 0;
            for (int i = 2; i <= n; i++)
            {
                ans = x + y;
                x = y;
                y = ans;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");

            int sum = 0;
            double mull = 1;

            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                mull *= num;

            }
            Console.WriteLine($"Mull: {mull}, Sum: {sum}");

            Console.Write("Начало: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Конец: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 50; i++)
            {
                int n = fib(i);
                if (n >= start && n <= end)
                    Console.WriteLine(n);
                if (n > end)
                    break;
            }

            Console.ReadKey();
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (A <= B)
            {
                for (int i = 1; i <= A; i++)
                    Console.Write("{0}", A);
                A++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
