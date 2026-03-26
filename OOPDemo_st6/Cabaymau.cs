using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo_st6
{
    public class Cabaymau : Lopca
    {
        // thuoc tinh
        private int so_mau;
        public Cabaymau(string ten_ca, string mau_sac, double can_nang, bool co_vay, int so_mau) : 
            base(ten_ca, mau_sac, can_nang, co_vay) // ham khoi tao tu cha 
        {
            this.so_mau=so_mau;
        }

        public override void Cachboi()
        {
            Console.WriteLine("Ca boi tung tang tren mat nuoc!!!");
        }
        public override void Inthongtin()
        {
            base.Inthongtin();
            Console.WriteLine("Ca co {0} mau.", so_mau);
        }
        public override string ToString()
        {
            return ten_ca;// in ra chinh no
        }
    }
}
