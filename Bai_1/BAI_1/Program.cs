using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhsachsonguyen = new List<int>();

            danhsachsonguyen.Add(19);
            danhsachsonguyen.Add(11);
            danhsachsonguyen.Add(123);
            danhsachsonguyen.Add(5324);
            danhsachsonguyen.Add(4234);

            Console.WriteLine("danh sach cac so nguyen da them");
            foreach (int so in danhsachsonguyen)
            {
                Console.WriteLine(so);
            }
            Console.ReadLine();
        }
    }
}
