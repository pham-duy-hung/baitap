using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot chuoi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> demKyTu = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ') continue;

                if (demKyTu.ContainsKey(c))
                {
                    demKyTu[c]++;
                }
                else
                {
                    demKyTu.Add(c, 1);
                }
            }

            Console.WriteLine("\nKet qua thong ke:");
            foreach (KeyValuePair<char, int> entry in demKyTu)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}
