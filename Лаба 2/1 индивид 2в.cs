using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а =");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b =");
            double b = double.Parse(Console.ReadLine());


            if (a < 0 ^ b < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {

                if (a < b)
                {
                    a = Math.Sqrt(a);
                    Console.Write("a=");
                    Console.WriteLine(a);              
                }

                else
                {
                    b = Math.Sqrt(b);
                    Console.Write("b=");
                    Console.WriteLine(b);
                }
            }
            


            Console.ReadKey();
        }
    }
}
