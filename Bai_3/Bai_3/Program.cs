using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSachSoNguyen = new List<int>();

            Console.WriteLine("nhap 5 so nguyen vao list");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"nhap so thu {i + 1} vao list");
                int n = int.Parse(Console.ReadLine());
                danhSachSoNguyen.Add(n);
            }
            int max = danhSachSoNguyen.Max();
            Console.WriteLine($"So lon nhat la: {max}");
            Console.ReadLine();
        }
    }
}
