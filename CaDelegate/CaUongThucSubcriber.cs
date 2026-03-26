using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaDelegate
{
    public class CaUongThucSubcriber
    {
        public CaUongThucSubcriber(LopCa ca)
        {
            ca.OnCaBenh+= new LopCa.CaBenhEvenHandler(ChoCaUongThuoc);
        }
        public void ChoCaUongThuoc(LopCa ca, CaBenhEventArgs ev)
        {
            Console.WriteLine("Thong bao: {0}", ev.Thong_Bao);
            string tc = ev.Trieu_Chung.ToUpper();
            if (tc.Equals("DAU DAU"))
                Console.WriteLine("Uong panadol khi dau dau.");
            else
            if (tc.Equals("DAU RANG"))
                Console.WriteLine("Uong IDARAC giam dau rang.");
            else
                Console.WriteLine($"{tc} thi uong XUYEN TAM LIEN.");
        }

    }
}
