using System;
using System.Collections.Generic;
using System.Linq; // Cần thiết để dùng .Any()

namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> danhSachPhim = new List<string> { "Iron Man", "Spider Man", "Thor", "Batman", "Joker" };

            Console.WriteLine("Danh sach hien co: " + string.Join(", ", danhSachPhim));

            Console.Write("\nNhap ten phim ban muon tim: ");
            string timKiem = Console.ReadLine();

            bool tonTai = danhSachPhim.Any(x => x.Equals(timKiem, StringComparison.OrdinalIgnoreCase));

            if (tonTai)
            {
                Console.WriteLine($"Ket qua: Chuoi '{timKiem}' CO ton tai trong danh sach.");
            }
            else
            {
                Console.WriteLine($"Ket qua: Chuoi '{timKiem}' KHONG ton tai.");
            }
            Console.ReadKey();
        }
    }
}