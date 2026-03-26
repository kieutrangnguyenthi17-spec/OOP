using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    public class LopCa : IBoi
    {
        private string ten_ca;
        private string mau_sac;
        private double can_nang;
        private bool co_vay;
        // constructor
        public LopCa(string ten_ca, string mau_sac, double can_nang, bool co_vay)
        {
            this.ten_ca=ten_ca;
            this.mau_sac=mau_sac;
            this.can_nang=can_nang;
            this.co_vay=co_vay;
        }

        // encapsulation
        public string getTen_ca()
        {
            return ten_ca;
        }
        // implement CachBoi() in IBoi
        //virtual -> override con
        public void CachBoi()
        {
            Console.WriteLine("Ca la phai biet boi!!!");
        }

        //methods
        public virtual void inThongTin()
        {
            Console.WriteLine("Ten ca : {0}", ten_ca);
            Console.WriteLine("Mau sac : {0}", mau_sac);
            Console.WriteLine("Can nang : {0}", can_nang);
            Console.WriteLine("La ca {0}", (co_vay ? "co vay" : "da tron"));
        }
    }
}
