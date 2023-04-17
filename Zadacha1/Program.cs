using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string shablon = Console.ReadLine();
            string output = input;
            byte couter = 0;

            while (output.Contains(shablon))
            {
                couter++;
                int pos = output.IndexOf(shablon);
                int len = shablon.Length;
                output = output.Remove(pos, len);
            }

            if (couter >= 2)
            {
                Console.WriteLine("Shaked it!");
            }
            Console.WriteLine("No shake!");

            Console.WriteLine(output);
        }
    }
}
