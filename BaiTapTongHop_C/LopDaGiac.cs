using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHop_C
{
    public abstract class LopDaGiac
    {
        //attributes
        private int so_canh;
        public double[] cd_canh;
        //constructor 
        public LopDaGiac(int so_canh)
        {
            this.so_canh= so_canh;
            cd_canh = new double[so_canh];
            
            
        }
        //methods
        public abstract double tinhchuvi();
        public abstract double tinhdientich();

    }
}
