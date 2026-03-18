using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> tuDien = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            tuDien.Add("Hello", "Xin chao");
            tuDien.Add("Student", "Sinh vien");
            tuDien.Add("Programmer", "Lap trinh vien");
            tuDien.Add("Library", "Thu vien");
            tuDien.Add("School", "Truong hoc");

            Console.WriteLine("Cac tu dang co: " + string.Join(", ", tuDien.Keys));

            Console.Write("\nNhap tu tieng Anh can tra nghia: ");
            string tuCanTra = Console.ReadLine();

            if (tuDien.TryGetValue(tuCanTra, out string nghia))
            {
                Console.WriteLine($"\nNghia cua '{tuCanTra}' la: {nghia}");
            }
            else
            {
                Console.WriteLine($"\nRat tiec, tu '{tuCanTra}' chua co trong tu dien.");
            }

            Console.WriteLine("\nNhan phim bat ky de ket thuc.");
            Console.ReadKey();
        }
    }
}