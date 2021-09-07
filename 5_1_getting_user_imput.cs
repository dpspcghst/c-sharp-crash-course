using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string your_name;
            Console.WriteLine("What is your name?");
            
            your_name = Console.ReadLine();
            
            Console.WriteLine("Hello {0}", your_name);
            
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}
