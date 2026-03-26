using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaDelegate
{
    //2. lop publisher (sender)
    public class LopCa
    {
        private string ten_ca;
        public LopCa(string ten_ca)
        {
            this.ten_ca = ten_ca;
        }
        // delegate - event
        public delegate void CaDoiEvenHandler(LopCa ca, CaDoiEventArgs ev);
        public event CaDoiEvenHandler OnCaDoi;

        public delegate void CaBenhEvenHandler(LopCa ca, CaBenhEventArgs ev);
        public event CaBenhEvenHandler OnCaBenh;
        // notify
        public void CaDoiRoi()
        {
            CaDoiEventArgs ev = new CaDoiEventArgs("Doi qua nha chu oi!!!");
            //raise event
            if(OnCaDoi !=null)
            {
                OnCaDoi(this, ev);
            }
        }
        public void CaBenhRoi(string trieu_chung)
        {
            CaBenhEventArgs ev = new CaBenhEventArgs("Benh nang roi!!!", trieu_chung);
            //raise event
            if(OnCaBenh !=null)
            {
                OnCaBenh(this, ev);
            }
        }
    }
}
