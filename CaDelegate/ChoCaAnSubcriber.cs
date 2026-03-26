using CaDelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaDelegate.LopCa;

namespace CaDelegate
{
    // 3. Lop Subcriber
    public class ChoCaAnSubcriber
    {
        public ChoCaAnSubcriber(LopCa ca)
        {
            ca.OnCaDoi += new CaDoiEvenHandler(choCaAnKhiDoi);
        }
        public void choCaAnKhiDoi(LopCa ca, CaDoiEventArgs ev)
        {
            Console.WriteLine("Thong bao khan: {0}", ev.Thong_Bao);
            DateTime dt = System.DateTime.Now;
            int h = dt.Hour;
            Console.WriteLine("Gio hien tai: {0}", dt.ToString());
            if (h >= 5 && h <= 12)
                Console.WriteLine("Cho cac an Hu tieu Ca!!");
            else
                if (h > 12 && h <= 17)
                Console.WriteLine("Cho cac an Bun Ca!!");
            else
                if (h > 17 && h <= 24)
                Console.WriteLine("Co ca an Lau Ca!!!");
            else
                Console.WriteLine("Cho ca len chao!!!");
        }
    }
}
