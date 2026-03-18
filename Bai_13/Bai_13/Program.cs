using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_13
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
            List<Student> dsSinhVien = new List<Student>
            {
                new Student(2415, "Pham Duy Hung"),
                new Student(1002, "Nguyen Van An"),
                new Student(1003, "Tran Thi Hoa")
            };

             int tongSo = dsSinhVien.Count(); 

            Console.WriteLine($"Tong so sinh vien hien co: {tongSo}");

            Console.WriteLine("\nDanh sach chi tiet:");
            foreach (var st in dsSinhVien)
            {
                Console.WriteLine($"- {st.Name} (ID: {st.Id})");
            }

            Console.ReadKey();
        }
    }
}