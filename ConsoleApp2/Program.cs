using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            int num2=0;

            try
            {

                Console.WriteLine("Enter n1:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N2:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter just Number");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

            Console.WriteLine("sum is: " + (num1 + num2));


            Console.WriteLine("Enter a Key to exit ...");
            Console.ReadKey();
        }
    }
}
