using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace ModuleDN
{
    public partial class ucThongTinSV : UserControl
    {
        SQLClass sql = new SQLClass();
        string cnn;
        public string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }
        
        public ucThongTinSV()
        {
            InitializeComponent();
            this.btnTim.Click += btnTim_Click;
        }

        
        void btnTim_Click(object sender, EventArgs e)
        {
            sql.CreateConnection(cnn);
            string MSSV = txtMSSV.Text.Trim();


            if (string.IsNullOrEmpty(MSSV))
            {
                MessageBox.Show("MSSV không được để trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            string query = "SELECT * FROM ThongTinSV WHERE MSSV = '" + MSSV + "'";

            DataTable dt = sql.ExcuteQuery(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lb_Ten.Text = row["TenSV"].ToString();
                lb_NgaySinh.Text = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy");
                lb_GT.Text = row["GioiTinh"].ToString();
                lb_MaLop.Text = row["MaLop"].ToString();
                lb_CMND.Text = row["CMND"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với MSSV này", "Thông báo", MessageBoxButtons.OK);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucThongTinSV_Load(object sender, EventArgs e)
        {
            


        }
    }
}
