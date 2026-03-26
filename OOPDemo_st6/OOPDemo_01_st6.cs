using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo_st6
{
    public class OOPDemo_01_st6
    {
        // entry point - diem truy cap
        static void Main(string[] args)
        {
            // Lopca caao = new Lopca();
            Cabaymau cbm01 = new Cabaymau("Nam","Den",0.01,true,1);

            Console.WriteLine("Thong tin cua ca {0}:",cbm01);
            cbm01.Inthongtin();
            cbm01.Cachboi();

            Console.ReadKey();
        }

        
    }
}
