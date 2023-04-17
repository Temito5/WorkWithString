using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray();
            string izrechenie = Console.ReadLine();

            foreach (var item in word)
            {
                if (izrechenie.Contains(item))
                {
                    izrechenie = izrechenie.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(izrechenie);
        }
    }
}
