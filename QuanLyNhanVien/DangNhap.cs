using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyNhanVien
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Summer 2008");
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadDataUser(textDangNhap.Text, textMK.Text);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng");
            }


        }

        private void ShowMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowMK.Checked == true)
            {
                textMK.UseSystemPasswordChar = false;
            }
            else
            {
                textMK.UseSystemPasswordChar = true;

            }
        }
    }
}