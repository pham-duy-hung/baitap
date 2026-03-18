using System;
using System.Collections.Generic;
using System.Linq; 
namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSach = new List<int> { 1, 3, 5, 7, 9 };

            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", danhSach));

            var danhSachDaoNguoc = danhSach.AsEnumerable().Reverse().ToList();

            Console.WriteLine("Danh sach sau khi dao nguoc: " + string.Join(", ", danhSachDaoNguoc));
            Console.WriteLine("Danh sach goc van giu nguyen: " + string.Join(", ", danhSach));

            Console.ReadLine();
        }
    }
}