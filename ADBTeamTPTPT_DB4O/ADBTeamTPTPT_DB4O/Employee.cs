using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2020
{
    [Serializable]
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string HoTen { get; set; }
        public string Skill { get; set; }
        public CongTy HomeBase { get; set; }
        public NhanVien QuanLy { get; set; }
        public double Luong { get; set; }
        public NhanVien(string _ht, string _sk, CongTy _ct, double _l)
        {
            HoTen = _ht;
            Skill = _sk;
            HomeBase = _ct;
            QuanLy = null;
            Luong = _l;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} ({2})", HoTen, Skill, Luong);
        }
    }
}
