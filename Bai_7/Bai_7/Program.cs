using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSach = new List<int>();
            Console.WriteLine("Nhap cac so nguyen (Nhap 'q' de dung):");

            // 1. Nhập danh sách từ bàn phím
            while (true)
            {
                Console.Write("Nhap so: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "q") break;

                if (int.TryParse(input, out int so))
                {
                    danhSach.Add(so);
                }
            }

            if (danhSach.Count > 0)
            {
                var danhSachTangDan = danhSach.OrderBy(x => x).ToList();

                var danhSachGiamDan = danhSach.OrderByDescending(x => x).ToList();

                Console.WriteLine("Danh sach goc: " + string.Join(", ", danhSach));
                Console.WriteLine("Sau khi sap xep TANG DAN: " + string.Join(", ", danhSachTangDan));
                Console.WriteLine("Sau khi sap xep GIAM DAN: " + string.Join(", ", danhSachGiamDan));
            }
            else
            {
                Console.WriteLine("Danh sach trong!");
            }

            Console.ReadKey();
        }
    }
}