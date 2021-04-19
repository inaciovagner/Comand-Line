using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Comand_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                WriteLine("Two arguments required.");
                return;
            }
            {
                string param1 = args[0];
                int param2 = ToInt32(args[1]);
                WriteLine($"String parameter: {param1}");
                WriteLine($"Integer parameter: {param2}");
            }
        }
    }
}