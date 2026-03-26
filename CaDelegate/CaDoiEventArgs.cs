using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaDelegate
{
    // 1. Lop su kien
    public class CaDoiEventArgs : EventArgs
    {
        private string thong_bao;
        public CaDoiEventArgs(string thong_bao)
        {
            this.thong_bao = thong_bao;
        }
        // property
        public string Thong_Bao
        {
            get { return this.thong_bao; }
            set { this.thong_bao = value; }
        }
    }
}
