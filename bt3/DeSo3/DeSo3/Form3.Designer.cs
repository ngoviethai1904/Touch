namespace DeSo3
{
    partial class F_TTChiTiet
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
            this.lbmanxb = new System.Windows.Forms.Label();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.lbtennxb = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbmanxb
            // 
            this.lbmanxb.AutoSize = true;
            this.lbmanxb.Location = new System.Drawing.Point(56, 104);
            this.lbmanxb.Name = "lbmanxb";
            this.lbmanxb.Size = new System.Drawing.Size(47, 13);
            this.lbmanxb.TabIndex = 0;
            this.lbmanxb.Text = "Mã NXB";
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(141, 101);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(172, 20);
            this.txtmanxb.TabIndex = 1;
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(141, 149);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(172, 20);
            this.txttennxb.TabIndex = 3;
            // 
            // lbtennxb
            // 
            this.lbtennxb.AutoSize = true;
            this.lbtennxb.Location = new System.Drawing.Point(56, 152);
            this.lbtennxb.Name = "lbtennxb";
            this.lbtennxb.Size = new System.Drawing.Size(51, 13);
            this.lbtennxb.TabIndex = 2;
            this.lbtennxb.Text = "Tên NXB";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(141, 192);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(172, 20);
            this.txtdiachi.TabIndex = 5;
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(56, 195);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(41, 13);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin Nhà Xuất Bản";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(252, 236);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(160, 236);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(59, 236);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // F_TTChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 295);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.txttennxb);
            this.Controls.Add(this.lbtennxb);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.lbmanxb);
            this.Name = "F_TTChiTiet";
            this.Text = "Thông Tin Chi Tiết";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_TTChiTiet_FormClosed);
            this.Load += new System.EventHandler(this.F_TTChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmanxb;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.Label lbtennxb;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
    }
}