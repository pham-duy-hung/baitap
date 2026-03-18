using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18
{
    class Student
    {
        public string Name;
        public double Score;

        public Student(string name, double score)
        {
            Name = name;
            Score = score;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> dsSinhVien = new List<Student>
            {
                new Student("Pham Duy Hung", 8.5),
                new Student("Nguyen Van An", 9.2),
                new Student("Tran Thi Hoa", 7.8),
                new Student("Le Van Binh", 9.2)
            };
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var s in dsSinhVien) Console.WriteLine($"- {s.Name}: {s.Score}");

            if (dsSinhVien.Count > 0)
            {
                double diemCaoNhat = dsSinhVien.Max(s => s.Score);
                var danhSachThuKhoa = dsSinhVien.Where(s => s.Score == diemCaoNhat).ToList();

                Console.WriteLine($"Diem cao nhat la: {diemCaoNhat}");
                Console.WriteLine("Sinh vien dat diem cao nhat:");

                foreach (var st in danhSachThuKhoa)
                {
                    Console.WriteLine($"==> {st.Name} ({st.Score} diem)");
                }
            }
            else
            {
                Console.WriteLine("Danh sach trong!");
            }

            Console.ReadKey();
        }
    }
}