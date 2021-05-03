using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Missingnumber();
        }
        public static void Missingnumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int result = input.Split(' ').Select(int.Parse).Sum();
            int total = n * (n + 1) / 2;
            Console.WriteLine(total - result);
            Console.ReadLine();
        }
      
    }
}
