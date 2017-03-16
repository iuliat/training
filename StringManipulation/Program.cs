using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // StrShift x;
            // x = "Microsoft";

            // string s = x << 1;
            // Console.WriteLine("Result: {0}", s<<1);

           StrShift example;
           example = "Microsoft";
            //Console.WriteLine("{0}\n", (example >> 3));
            // Console.WriteLine("{0}\n", example.ToString());
            StrShift example2 = "Microsoft";
            Console.WriteLine("{0}\n", example==example2);
           string input = Console.ReadLine();
        }
    }
}
