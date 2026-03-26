// GENERIC METHOD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGenericdemo02
{
    public class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a=b;
            b=temp;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}"); // x=10, y=5

            string s1 = "Hello", s2 = "World";
            Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s1}, s2={s2}"); // s1= World, s2= Hello


            Console.ReadKey();
        }
    }
}
