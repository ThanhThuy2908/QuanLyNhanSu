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