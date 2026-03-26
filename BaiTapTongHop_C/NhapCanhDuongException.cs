using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHop_C
{
    public class NhapCanhDuongException : ApplicationException // 1 lop trong ct de bao loi ct
    {
        public NhapCanhDuongException(string message) : base(message)
            {
            }
    }
}
