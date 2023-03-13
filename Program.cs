using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_alireza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("enter your number you want caculate:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your + - / * :");
            char s = Convert.ToChar(Console.ReadLine());
            if(s == '+')
            {
                Console.WriteLine(y + x);
            }
            if(s == '-')
            {
                    Console.WriteLine(x - y);
            }
            if(s == '*')
            {
                Console.WriteLine(x * y);
            }
            if(s == '/')
            {
                Console.WriteLine(x / y);
            }
             
            

        }
    }
}
