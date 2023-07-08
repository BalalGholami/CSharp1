using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to C#...");
            Console.ResetColor();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
