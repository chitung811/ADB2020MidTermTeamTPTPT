using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2020
{
    [Serializable]
    public class CongTy
    {
        public Guid MaCongTy { get; set; }
		public string MaSoThue { get; set; }
        public string TenCongTy { get; set; }
        public string SoNha { get; set; }
        public string DuongPho { get; set; }
        public string QuanHuyen { get; set; }
		public NhanVien GiamDoc { get; set; }

        public CongTy(string _mst, string _tct, string _sn, string _dp, string _qh)
        {
            MaSoThue = _mst;
            TenCongTy = _tct;
            SoNha = _sn;
            DuongPho = _dp;
            QuanHuyen = _qh;
            GiamDoc = null;
        }
        public override string ToString()
        {
            return TenCongTy;
        }
    }
}
