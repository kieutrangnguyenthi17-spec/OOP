using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo_st6
{
    public abstract class Lopca // ca thuc- phan thuc
    {
        //thuoc tinh
        protected string ten_ca;
        private string mau_sac;
        private double can_nang;
        private bool co_vay;
        //ham tao - ham dung - constructor
        public Lopca(string ten_ca, string mau_sac, double can_nang, bool co_vay)
        {
            this.ten_ca=ten_ca;
            this.mau_sac=mau_sac;
            this.can_nang=can_nang;
            this.co_vay=co_vay;
        }
        //phuong thuc - kha nang cua doi tuong
        public virtual void Inthongtin()
        {
            Console.WriteLine("Ten ca : {0}.", ten_ca);
            Console.WriteLine("Ca co mau : {0}.", mau_sac);
            Console.WriteLine("Ca nang {0:0.00}kg.", can_nang);
            Console.WriteLine("La ca {0}.",(co_vay ? "co vay" : "da tron")); 
        }
        public abstract void Cachboi(); //phan ao

    }
}
