﻿using System;
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
    public partial class frm_b11 : Form
    {
        public frm_b11()
        {
            InitializeComponent();
            ucThongTinSV1.Cnn = "Data Source=A202PC01;Initial Catalog=DN;User ID=sa;Password=123";
        }
    }

}
