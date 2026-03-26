using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CaDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            //sender
            LopCa caMap = new LopCa("Map U");
            //subcriber
            ChoCaAnSubcriber chocaan = new ChoCaAnSubcriber(caMap);
            //su kien xay ra 
            caMap.CaDoiRoi();

            //
            CaUongThucSubcriber chocauongthuoc = new CaUongThucSubcriber(caMap);
            caMap.CaBenhRoi("dau dau");

            Console.ReadKey();
        }
    }
}