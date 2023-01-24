using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRomanToArabian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Roman number(for example XXI): ");
            string str = Console.ReadLine();
            Console.WriteLine(Roman.Parse(str));
            Console.ReadLine();
        
        }
    }
}
