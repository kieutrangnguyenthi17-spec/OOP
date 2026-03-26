using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHop_C
{
    public class HinhVuong : LopDaGiac
    {
        public HinhVuong() : base(1)
        {
NhapCanhHinhVuong:
            try
            {
                Console.Write("Nhap chieu dai canh hinh vuong: ");
                cd_canh[0]=Double.Parse(Console.ReadLine());
                if (cd_canh[0] <= 0)
                    throw new NhapCanhDuongException("Nhap so >0!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nhap nhap du lieu la so!!!");
                goto NhapCanhHinhVuong;
            }
            catch (NhapCanhDuongException ex)
            {
                Console.WriteLine("{0}", ex.Message);
                goto NhapCanhHinhVuong;
            }
        }

        public override double tinhchuvi()
        {
            return cd_canh[0]*4;
        }
        public override double tinhdientich()
        {
            return cd_canh[0]*cd_canh[0];
        }
    }
}
       