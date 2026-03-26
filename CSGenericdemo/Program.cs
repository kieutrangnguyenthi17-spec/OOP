using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGenericdemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStacks<int> intStack = new MyStacks<int>();
            intStack.Push(10);
            intStack.Push(20);
            Console.WriteLine(intStack.Pop()); //20

            MyStacks<string> strStack = new MyStacks<string>();
            strStack.Push("Hello");
            strStack.Push("World");
            Console.WriteLine(strStack.Pop()); //World

            Console.ReadKey();
        }
    }
}
