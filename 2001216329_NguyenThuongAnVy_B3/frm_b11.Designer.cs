﻿namespace _2001216329_NguyenThuongAnVy_B3
{
    partial class frm_b11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucThongTinSV1 = new ModuleDN.ucThongTinSV();
            this.SuspendLayout();
            // 
            // ucThongTinSV1
            // 
            this.ucThongTinSV1.Cnn = null;
            this.ucThongTinSV1.Location = new System.Drawing.Point(3, 6);
            this.ucThongTinSV1.Name = "ucThongTinSV1";
            this.ucThongTinSV1.Size = new System.Drawing.Size(510, 258);
            this.ucThongTinSV1.TabIndex = 0;
            // 
            // frm_b11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 276);
            this.Controls.Add(this.ucThongTinSV1);
            this.Name = "frm_b11";
            this.Text = "frm_b11";
            this.ResumeLayout(false);

        }

        #endregion

        private ModuleDN.ucThongTinSV ucThongTinSV1;
    }
}