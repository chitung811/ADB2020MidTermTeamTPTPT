using Db4objects.Db4o;
using MidTerm2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTeamTPTPT_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemCongTy addct = new FormThemCongTy();
            addct.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Them 10 nhan vien
        private void button2_Click(object sender, EventArgs e)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile("ADBTeamTPTPT_EmployeeManage.yap");
            CongTy tmp = new CongTy(null, null, null, null, null);
            IList<CongTy> r = db.Query(delegate (CongTy a)
            {
                return true;
            });
            Object s = r[0];
            CongTy a = new CongTy(r[0].MaSoThue, r[0].TenCongTy, r[0].SoNha, r[0].DuongPho, r[0].QuanHuyen);
            CongTy b = new CongTy(r[1].MaSoThue, r[1].TenCongTy, r[1].SoNha, r[1].DuongPho, r[1].QuanHuyen);
            CongTy c = new CongTy(r[2].MaSoThue, r[2].TenCongTy, r[2].SoNha, r[2].DuongPho, r[2].QuanHuyen);
            CongTy d = new CongTy(r[3].MaSoThue, r[3].TenCongTy, r[3].SoNha, r[3].DuongPho, r[3].QuanHuyen);
            CongTy f = new CongTy(r[4].MaSoThue, r[4].TenCongTy, r[4].SoNha, r[4].DuongPho, r[4].QuanHuyen);
            NhanVien nv1 = new NhanVien("Thành Phát","Intern", a ,null , 400);
            db.Store(nv1);
            NhanVien nv2 = new NhanVien("Trần Hưng", "Intern", a, null, 300);
            db.Store(nv2);
            NhanVien nv3 = new NhanVien("Minh Đạt", "Fresher", b, null, 500);
            db.Store(nv3);
            NhanVien nv4 = new NhanVien("Nguyễn Nghĩa", "Fresher", b, null, 500);
            db.Store(nv4);
            NhanVien nv5 = new NhanVien("Trần Tâm", "Fresher", c, null, 600);
            db.Store(nv5);
            NhanVien nv6 = new NhanVien("Lê Thị Trân", "Intern", c, null, 300);
            db.Store(nv6);
            NhanVien nv7 = new NhanVien("Nghĩa Luân", "Intern", d, null, 300);
            db.Store(nv7);
            NhanVien nv8 = new NhanVien("Trần Thành", "Intern", d, null, 350);
            db.Store(nv8);
            NhanVien nv9 = new NhanVien("Ưng Tuấn", "Fresher",f, null, 500);
            db.Store(nv9);
            NhanVien nv10 = new NhanVien("Lê Anh", "Fresher",f, null, 500);
            db.Store(nv10);
            db.Close();
        }
    }
}
