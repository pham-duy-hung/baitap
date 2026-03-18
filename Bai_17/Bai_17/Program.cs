using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSach = new List<int> { 1, 3, 2, 3, 4, 1, 3, 5, 2 };

            Console.WriteLine("Danh sach: " + string.Join(", ", danhSach));

            Dictionary<int, int> thongKe = new Dictionary<int, int>();

            foreach (int so in danhSach)
            {
                if (thongKe.ContainsKey(so))
                    thongKe[so]++;
                else
                    thongKe[so] = 1;
            }
            var phanTuMax = thongKe.OrderByDescending(x => x.Value).FirstOrDefault();
            if (thongKe.Count > 0)
            {
                Console.WriteLine($"So xuat hien nhieu nhat la: {phanTuMax.Key}");
                Console.WriteLine($"So lan xuat hien: {phanTuMax.Value} lan");
            }
            else
            {
                Console.WriteLine("Danh sach trong!");
            }

            Console.ReadKey();
        }
    }
}