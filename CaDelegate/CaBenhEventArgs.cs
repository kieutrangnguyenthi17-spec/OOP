using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaDelegate
{
    public class CaBenhEventArgs : EventArgs
    {
        private string thong_bao;
        private string trieu_chung;
        public CaBenhEventArgs(string thong_bao, string trieu_chung)
        {
            this.thong_bao=thong_bao;
            this.trieu_chung=trieu_chung;
        }
        //properties
        public string Thong_Bao
        {
           get
            {
                return thong_bao;
            }
            set
            {
                this.thong_bao =value;
            }

        }
        public string Trieu_Chung
        {
            get
            {
                return trieu_chung;
            }
            set
            {
                trieu_chung =value;
            }
        }
    }
}
