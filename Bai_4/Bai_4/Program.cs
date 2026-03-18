using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSachSoNguyen = new List<int>();

            while (true)
            {
                Console.Write("Nhap so: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int so))
                {
                    break;
                }
                danhSachSoNguyen.Add(so);
            }
            
                int dem = danhSachSoNguyen.Count(x => x % 2 == 0);
            Console.WriteLine($"So luong so chan: {dem}");
            Console.ReadLine();
        }
    }
}
