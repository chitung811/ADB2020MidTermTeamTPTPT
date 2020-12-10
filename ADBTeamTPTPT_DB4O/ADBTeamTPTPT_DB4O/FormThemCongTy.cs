using Db4objects.Db4o;
using MidTerm2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADBTeamTPTPT_DB4O
{
    public partial class FormThemCongTy : Form
    {
        public FormThemCongTy()
        {
            InitializeComponent();
        }

        private void FormThemCongTy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile("ADBTeamTPTPT_EmployeeManage.yap");
            CongTy add = new CongTy(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            db.Store(add);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            db.Close();
        }
    }
}
