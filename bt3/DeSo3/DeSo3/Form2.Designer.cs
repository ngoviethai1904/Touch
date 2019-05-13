namespace DeSo3
{
    partial class F_QLSach
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
            this.tvdstacgia = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvsach = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnluucapnhat = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbnhaxb = new System.Windows.Forms.ComboBox();
            this.lbnhaxb = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.lbdongia = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.lbtensach = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lbmasach = new System.Windows.Forms.Label();
            this.txttongtiensach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbqls = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvdstacgia
            // 
            this.tvdstacgia.Location = new System.Drawing.Point(7, 22);
            this.tvdstacgia.Margin = new System.Windows.Forms.Padding(4);
            this.tvdstacgia.Name = "tvdstacgia";
            this.tvdstacgia.Size = new System.Drawing.Size(266, 210);
            this.tvdstacgia.TabIndex = 0;
            this.tvdstacgia.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvdstacgia_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvdstacgia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(280, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục tác giả";
            // 
            // lvsach
            // 
            this.lvsach.Location = new System.Drawing.Point(132, 367);
            this.lvsach.Name = "lvsach";
            this.lvsach.Size = new System.Drawing.Size(661, 140);
            this.lvsach.TabIndex = 2;
            this.lvsach.UseCompatibleStateImageBehavior = false;
            this.lvsach.View = System.Windows.Forms.View.Details;
            this.lvsach.DoubleClick += new System.EventHandler(this.lvsach_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnluucapnhat);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.cmbnhaxb);
            this.groupBox2.Controls.Add(this.lbnhaxb);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.lbdongia);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.lbsoluong);
            this.groupBox2.Controls.Add(this.txttensach);
            this.groupBox2.Controls.Add(this.lbtensach);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.lbmasach);
            this.groupBox2.Location = new System.Drawing.Point(325, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 232);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhập Sách";
            // 
            // btnluucapnhat
            // 
            this.btnluucapnhat.Location = new System.Drawing.Point(441, 103);
            this.btnluucapnhat.Name = "btnluucapnhat";
            this.btnluucapnhat.Size = new System.Drawing.Size(93, 29);
            this.btnluucapnhat.TabIndex = 15;
            this.btnluucapnhat.Text = "Lưu Cập Nhật";
            this.btnluucapnhat.UseVisualStyleBackColor = true;
            this.btnluucapnhat.Click += new System.EventHandler(this.btnluucapnhat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(441, 41);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(93, 29);
            this.btncapnhat.TabIndex = 14;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(302, 164);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(93, 29);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(441, 164);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 29);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(302, 103);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(93, 29);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(302, 41);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 29);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbnhaxb
            // 
            this.cmbnhaxb.FormattingEnabled = true;
            this.cmbnhaxb.Location = new System.Drawing.Point(110, 188);
            this.cmbnhaxb.Name = "cmbnhaxb";
            this.cmbnhaxb.Size = new System.Drawing.Size(141, 23);
            this.cmbnhaxb.TabIndex = 9;
            // 
            // lbnhaxb
            // 
            this.lbnhaxb.AutoSize = true;
            this.lbnhaxb.Location = new System.Drawing.Point(19, 191);
            this.lbnhaxb.Name = "lbnhaxb";
            this.lbnhaxb.Size = new System.Drawing.Size(86, 15);
            this.lbnhaxb.TabIndex = 8;
            this.lbnhaxb.Text = "Nhà Xuất Bản:";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(110, 146);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(141, 21);
            this.txtdongia.TabIndex = 7;
            this.txtdongia.Click += new System.EventHandler(this.txtdongia_Click);
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // lbdongia
            // 
            this.lbdongia.AutoSize = true;
            this.lbdongia.Location = new System.Drawing.Point(19, 149);
            this.lbdongia.Name = "lbdongia";
            this.lbdongia.Size = new System.Drawing.Size(52, 15);
            this.lbdongia.TabIndex = 6;
            this.lbdongia.Text = "Đơn Giá";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(110, 108);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(141, 21);
            this.txtsoluong.TabIndex = 5;
            this.txtsoluong.Click += new System.EventHandler(this.txtsoluong_Click);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(19, 111);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(60, 15);
            this.lbsoluong.TabIndex = 4;
            this.lbsoluong.Text = "Số Lượng";
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(110, 70);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(141, 21);
            this.txttensach.TabIndex = 3;
            this.txttensach.Click += new System.EventHandler(this.txttensach_Click);
            // 
            // lbtensach
            // 
            this.lbtensach.AutoSize = true;
            this.lbtensach.Location = new System.Drawing.Point(19, 73);
            this.lbtensach.Name = "lbtensach";
            this.lbtensach.Size = new System.Drawing.Size(62, 15);
            this.lbtensach.TabIndex = 2;
            this.lbtensach.Text = "Tên Sách:";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(110, 32);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(141, 21);
            this.txtmasach.TabIndex = 1;
            this.txtmasach.Click += new System.EventHandler(this.txtmasach_Click);
            // 
            // lbmasach
            // 
            this.lbmasach.AutoSize = true;
            this.lbmasach.Location = new System.Drawing.Point(19, 35);
            this.lbmasach.Name = "lbmasach";
            this.lbmasach.Size = new System.Drawing.Size(59, 15);
            this.lbmasach.TabIndex = 0;
            this.lbmasach.Text = "Mã Sách:";
            // 
            // txttongtiensach
            // 
            this.txttongtiensach.Location = new System.Drawing.Point(562, 326);
            this.txttongtiensach.Name = "txttongtiensach";
            this.txttongtiensach.Size = new System.Drawing.Size(166, 21);
            this.txttongtiensach.TabIndex = 11;
            this.txttongtiensach.VisibleChanged += new System.EventHandler(this.txttongtiensach_VisibleChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng Tiền Sách:";
            // 
            // lbqls
            // 
            this.lbqls.AutoSize = true;
            this.lbqls.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqls.Location = new System.Drawing.Point(349, 21);
            this.lbqls.Name = "lbqls";
            this.lbqls.Size = new System.Drawing.Size(247, 36);
            this.lbqls.TabIndex = 12;
            this.lbqls.Text = "QUẢN LÝ SÁCH";
            // 
            // F_QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 519);
            this.Controls.Add(this.lbqls);
            this.Controls.Add(this.txttongtiensach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvsach);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_QLSach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.F_QLSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvdstacgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbnhaxb;
        private System.Windows.Forms.Label lbnhaxb;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label lbdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label lbtensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lbmasach;
        private System.Windows.Forms.TextBox txttongtiensach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lbqls;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnluucapnhat;
    }
}