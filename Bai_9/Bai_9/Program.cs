using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSachGoc = new List<int>();
            Console.WriteLine("Nhap cac so nguyen (Nhap 'q' de dung):");

            while (true)
            {
                Console.Write("Nhap so: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "q") break;

                if (int.TryParse(input, out int so))
                {
                    danhSachGoc.Add(so);
                }
            }

            if (danhSachGoc.Count > 0)
            {
                List<int> danhSachSach = danhSachGoc.Distinct().ToList();

                Console.WriteLine("Danh sach goc: " + string.Join(", ", danhSachGoc));
                Console.WriteLine("Danh sach sau khi loai trung: " + string.Join(", ", danhSachSach));
            }
            else
            {
                Console.WriteLine("Ban chua nhap so nao!");
            }

            Console.ReadKey();
        }
    }
}