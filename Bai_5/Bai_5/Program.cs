using System;
using System.Collections.Generic;

namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dsSinhVien = new List<string> { "Hung", "Lan", "Nam", "Hoa", "Binh" };

            Console.WriteLine("Danh sach sinh vien hien tai:");
            Console.WriteLine(string.Join(", ", dsSinhVien));

            Console.Write("\nNhap ten sinh vien muon xoa: ");
            string tenCanXoa = Console.ReadLine();
            bool daXoa = dsSinhVien.Remove(tenCanXoa);

            if (daXoa)
            {
                Console.WriteLine($"\nDa xoa sinh vien '{tenCanXoa}' thanh cong!");
            }
            else
            {
                Console.WriteLine($"\nKhong tim thay sinh vien '{tenCanXoa}' trong danh sach.");
            }

            Console.WriteLine("Danh sach sau khi cap nhat:");
            Console.WriteLine(string.Join(", ", dsSinhVien));

            Console.ReadLine();
        }
    }
}