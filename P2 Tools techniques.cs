using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first number...");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type *,/,+,-");
            string z = Console.ReadLine();
            Console.WriteLine("Type second number...");
            int y = Convert.ToInt32(Console.ReadLine());
            if (z == "+")
            {
                Console.WriteLine("Answer: {0}", x + y);
            }
            if (z == "-")
            {
                Console.WriteLine("Answer: {0}", x - y);
            }
            if (z == "*")
            {
                Console.WriteLine("Answer: {0}", x * y);
            }
            if (z == "/")
            {
                Console.WriteLine("Answer: {0}", x / y);
            }
            Console.ReadKey();

        }
    }
}
