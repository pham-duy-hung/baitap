using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSach = new List<int>();
            Console.WriteLine("Nhap cac so nguyen (Nhap 'q' de dung):");

            while (true)
            {
                Console.Write("Nhap so: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "q") break;

                if (int.TryParse(input, out int so))
                {
                    danhSach.Add(so);
                }
                else
                {
                    Console.WriteLine("Vui long nhap so hop le!");
                }
            }

            if (danhSach.Count > 0)
            {
                int min = danhSach.Min();

                Console.WriteLine($"Danh sach da nhap: {string.Join(", ", danhSach)}");
                Console.WriteLine($"Gia tri nho nhat : {min}");
            }
            else
            {
                Console.WriteLine("Danh sach trong, khong the tim Min!");
            }

            Console.WriteLine("\nNhan phim bat ky de ket thuc.");
            Console.ReadKey();
        }
    }
}