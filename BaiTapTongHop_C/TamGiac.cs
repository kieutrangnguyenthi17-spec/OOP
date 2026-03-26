using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHop_C
{
    public class TamGiac : LopDaGiac
    {
        private double a;
        private double b;
        private double c;
        public TamGiac() : base(1)
        {
NhapCanhTamGiac:
            try
            {
                double[] cd_canh = new double[3];
                for (int i = 0; i<3; i++)
                {
                    Console.Write("Nhap canh: ");
                    cd_canh[i]=double.Parse(Console.ReadLine());
                    if (cd_canh[i]<=0)
                        throw new NhapCanhDuongException("Nhap so > 0!!!");
                }
                this.a=cd_canh[0];
                this.b=cd_canh[1];
                this.c=cd_canh[2];
                if (a+b<=c||a+c<=b||b+c<=a)
                    throw new Exception("Ba canh nay khong tao thanh tam giac!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Phai nhap du lieu la so!!!");
                goto NhapCanhTamGiac;
            }
            catch (NhapCanhDuongException ex)
            {
                Console.WriteLine("{0}", ex.Message);
                goto NhapCanhTamGiac;
            }
            catch (Exception ex) // thêm vào
            {
                Console.WriteLine(ex.Message);
                goto NhapCanhTamGiac;
            }
        }
        public override double tinhchuvi()
        {
            return (a+b+c);
        }
        public override double tinhdientich()
        {
            double p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
