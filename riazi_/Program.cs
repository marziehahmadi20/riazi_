using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riazi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter x & y: ");

            Console.WriteLine("x = ");

            int X = Convert.ToInt32(Console.ReadLine());

            Console.Write("y = ");

            int Y = Convert.ToInt32(Console.ReadLine());
            calc(X, Y);
        }

        private static void calc(int x, int y)
        {
            double result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine("√|x|+y2 = {0}", result);

            Console.ReadKey();
        }
    }
}
