using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
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
        Console.WriteLine("Danh sach hien tai:");
        foreach (var st in dsSinhVien) Console.WriteLine($"- ID: {st.Id} | Ten: {st.Name}");

        Console.Write("\nNhap ID sinh vien can xoa: ");
        if (int.TryParse(Console.ReadLine(), out int idCanXoa))
        {
            int soLuongDaXoa = dsSinhVien.RemoveAll(s => s.Id == idCanXoa);

            if (soLuongDaXoa > 0)
            {
                Console.WriteLine($"\nDa xoa sinh vien co ID {idCanXoa} thanh cong!");
            }
            else
            {
                Console.WriteLine($"\nKhong tim thay sinh vien co ID {idCanXoa}.");
            }
        }
        else
        {
            Console.WriteLine("ID phai la mot so nguyen!");
        }

        // 3. In lại danh sách sau khi xóa
        Console.WriteLine("\nDanh sach sau khi cap nhat:");
        foreach (var st in dsSinhVien) Console.WriteLine($"- ID: {st.Id} | Ten: {st.Name}");

        Console.ReadKey();
    }
}
}
