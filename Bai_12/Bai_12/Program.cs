using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_12
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> dsSinhVien = new List<Student>();

            dsSinhVien.Add(new Student(2415, "Pham Duy Hung"));
            dsSinhVien.Add(new Student(1002, "Nguyen Van A"));
            dsSinhVien.Add(new Student(1003, "Tran Thi B"));

            Console.WriteLine("--- DANH SACH SINH VIEN ---");
            Console.WriteLine("{0,-10} {1,-20}", "MSSV", "Ho va Ten");

            foreach (Student st in dsSinhVien)
            {
                Console.WriteLine("{0,-10} {1,-20}", st.Id, st.Name);
            }
            Console.Write("Nhap ten sinh vien can tim: ");
            string tenCanTim = Console.ReadLine();
            var ketQua = dsSinhVien.Where(s => s.Name.ToLower().Contains(tenCanTim.ToLower())).ToList();

            if (ketQua.Count > 0)
            {
                Console.WriteLine($"Tim thay {ketQua.Count} ket qua phu hop:");
                foreach (var st in ketQua)
                {
                    Console.WriteLine($"- MSSV: {st.Id} | Ho ten: {st.Name}");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien nao co ten nhu tren.");
            }

            Console.ReadKey();
        }
    }
}
