using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216329_NguyenThuongAnVy_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucDangNhap1.Cnn = "Data Source=A202PC01;Initial Catalog=DN;User ID=sa;Password=123";

            ucDangNhap1.Load += UcDangNhap1_Load;
        }
        private void UcDangNhap1_Load(object sender, EventArgs e)
        {
            CheckLoginStatus();
        }

        private void CheckLoginStatus()
        {
            if (ucDangNhap1.IsLoginSuccessful)
            {
                frm_b11 frm = new frm_b11();
                frm.TopLevel = true; // Đảm bảo form có thể được hiển thị độc lập
                frm.Show();

            }
        }

    }
}
