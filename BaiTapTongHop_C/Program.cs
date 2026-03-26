using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHop_C
{
    public class Program
    {
        static void Main(string[] args)
        {
            HinhVuong hv01 = new HinhVuong();
            Console.WriteLine("Chu vi hinh vuong: {0:0.00}",
                hv01.tinhchuvi());
            Console.WriteLine("Dien tich hinh vuong: {0:0.00}",
                hv01.tinhdientich());
            Console.ReadKey();

            TamGiac tg01 = new TamGiac();
            Console.WriteLine("Chu vi tam giac: {0:0.00}",
                tg01.tinhchuvi());
            Console.WriteLine("Dien tich tam giac: {0:0.00}",
                tg01.tinhdientich());
            Console.ReadKey();

        }
    }
}
