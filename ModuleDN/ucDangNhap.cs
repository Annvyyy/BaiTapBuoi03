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
    //public partial class ucDangNhap : UserControl
    //{
    //    SQLClass sql = new SQLClass();
    //    string cnn;

    //    public string Cnn
    //    {
    //        get { return cnn; }
    //        set { cnn = value; }
    //    }
        
    //    public ucDangNhap()
    //    {
    //        InitializeComponent();
            
    //        this.btnDN.Click += btnDN_Click;

    //    }

    //    void btnDN_Click(object sender, EventArgs e)
    //    {
    //        sql.CreateConnection(cnn);
    //        string tendn = txtTen.Text;
    //        string matkhau = txtMK.Text;
    //        if(string.IsNullOrEmpty(tendn))
    //        {
    //            MessageBox.Show("Ten DN khong duoc de trong", "Loi", MessageBoxButtons.OK);
    //            return;
    //        }
    //        if (string.IsNullOrEmpty(matkhau))
    //        {
    //            MessageBox.Show("Mat khau khong duoc de trong", "Loi", MessageBoxButtons.OK);
    //            return;
    //        }
    //        string sqlQ = "select count(*) from NguoiDung where TenDN = '" + tendn + "' and MatKhau = '" + matkhau + "'";
    //        int kq = (int)sql.ExecuteScalar(sqlQ);

    //        if (kq == 1)
    //        {
    //            MessageBox.Show("Đăng nhập thành công!");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Đăng nhập thất bại!");
    //        }
            
    //    }
        

    public partial class ucDangNhap : UserControl
    {
        private SQLClass sql = new SQLClass();
        private string cnn;
        public bool IsLoginSuccessful { get; private set; }

        public string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }

        public ucDangNhap()
        {
            InitializeComponent();
            this.btnDN.Click += btnDN_Click;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            sql.CreateConnection(cnn);
            string tendn = txtTen.Text;
            string matkhau = txtMK.Text;

            if (string.IsNullOrEmpty(tendn))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            string sqlQ = "select count(*) from NguoiDung where TenDN = '" + tendn + "' and MatKhau = '" + matkhau + "'";

            int kq = (int)sql.ExecuteScalar(sqlQ);
            IsLoginSuccessful = (kq > 0);

            if (IsLoginSuccessful)
            {
                MessageBox.Show("Đăng nhập thành công!");
                OnSomeChanged();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

      