namespace ttcn.Forms
{
    partial class sukien
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
            this.grtimkiem = new System.Windows.Forms.GroupBox();
            this.chktheothoigian = new System.Windows.Forms.CheckBox();
            this.chkdiachi = new System.Windows.Forms.CheckBox();
            this.chktensukien = new System.Windows.Forms.CheckBox();
            this.chkmasukien = new System.Windows.Forms.CheckBox();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.msktimngaykt = new System.Windows.Forms.MaskedTextBox();
            this.msktimngaybd = new System.Windows.Forms.MaskedTextBox();
            this.txttimdiachi = new System.Windows.Forms.TextBox();
            this.txttimtensukien = new System.Windows.Forms.TextBox();
            this.txttimmasukien = new System.Windows.Forms.TextBox();
            this.grthongtin = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.mskthongtinngaykt = new System.Windows.Forms.MaskedTextBox();
            this.mskthongtinngaybd = new System.Windows.Forms.MaskedTextBox();
            this.txtthongtindiachi = new System.Windows.Forms.TextBox();
            this.txtthongtintensukien = new System.Windows.Forms.TextBox();
            this.txtthongtinmasukien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewsukien = new System.Windows.Forms.DataGridView();
            this.grtimkiem.SuspendLayout();
            this.grthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsukien)).BeginInit();
            this.SuspendLayout();
            // 
            // grtimkiem
            // 
            this.grtimkiem.Controls.Add(this.chktheothoigian);
            this.grtimkiem.Controls.Add(this.chkdiachi);
            this.grtimkiem.Controls.Add(this.chktensukien);
            this.grtimkiem.Controls.Add(this.chkmasukien);
            this.grtimkiem.Controls.Add(this.btnlamlai);
            this.grtimkiem.Controls.Add(this.btntim);
            this.grtimkiem.Controls.Add(this.msktimngaykt);
            this.grtimkiem.Controls.Add(this.msktimngaybd);
            this.grtimkiem.Controls.Add(this.txttimdiachi);
            this.grtimkiem.Controls.Add(this.txttimtensukien);
            this.grtimkiem.Controls.Add(this.txttimmasukien);
            this.grtimkiem.Location = new System.Drawing.Point(35, 26);
            this.grtimkiem.Name = "grtimkiem";
            this.grtimkiem.Size = new System.Drawing.Size(275, 605);
            this.grtimkiem.TabIndex = 0;
            this.grtimkiem.TabStop = false;
            this.grtimkiem.Text = "Tìm kiếm";
            // 
            // chktheothoigian
            // 
            this.chktheothoigian.AutoSize = true;
            this.chktheothoigian.Location = new System.Drawing.Point(16, 348);
            this.chktheothoigian.Name = "chktheothoigian";
            this.chktheothoigian.Size = new System.Drawing.Size(135, 24);
            this.chktheothoigian.TabIndex = 18;
            this.chktheothoigian.Text = "Theo thời gian";
            this.chktheothoigian.UseVisualStyleBackColor = true;
            this.chktheothoigian.Click += new System.EventHandler(this.chktheothoigian_Click);
            // 
            // chkdiachi
            // 
            this.chkdiachi.AutoSize = true;
            this.chkdiachi.Location = new System.Drawing.Point(16, 240);
            this.chkdiachi.Name = "chkdiachi";
            this.chkdiachi.Size = new System.Drawing.Size(120, 24);
            this.chkdiachi.TabIndex = 17;
            this.chkdiachi.Text = "Theo địa chỉ";
            this.chkdiachi.UseVisualStyleBackColor = true;
            this.chkdiachi.Click += new System.EventHandler(this.chkdiachi_Click);
            // 
            // chktensukien
            // 
            this.chktensukien.AutoSize = true;
            this.chktensukien.Location = new System.Drawing.Point(16, 138);
            this.chktensukien.Name = "chktensukien";
            this.chktensukien.Size = new System.Drawing.Size(152, 24);
            this.chktensukien.TabIndex = 16;
            this.chktensukien.Text = "Theo tên sự kiện";
            this.chktensukien.UseVisualStyleBackColor = true;
            this.chktensukien.Click += new System.EventHandler(this.chktensukien_Click);
            // 
            // chkmasukien
            // 
            this.chkmasukien.AutoSize = true;
            this.chkmasukien.Location = new System.Drawing.Point(16, 28);
            this.chkmasukien.Name = "chkmasukien";
            this.chkmasukien.Size = new System.Drawing.Size(151, 24);
            this.chkmasukien.TabIndex = 15;
            this.chkmasukien.Text = "Theo mã sự kiện";
            this.chkmasukien.UseVisualStyleBackColor = true;
            this.chkmasukien.Click += new System.EventHandler(this.chkmasukien_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(179, 558);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(81, 37);
            this.btnlamlai.TabIndex = 11;
            this.btnlamlai.Text = "Đặt lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(60, 558);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(81, 37);
            this.btntim.TabIndex = 14;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // msktimngaykt
            // 
            this.msktimngaykt.Location = new System.Drawing.Point(16, 464);
            this.msktimngaykt.Mask = "00/00/0000";
            this.msktimngaykt.Name = "msktimngaykt";
            this.msktimngaykt.Size = new System.Drawing.Size(155, 26);
            this.msktimngaykt.TabIndex = 13;
            this.msktimngaykt.ValidatingType = typeof(System.DateTime);
            // 
            // msktimngaybd
            // 
            this.msktimngaybd.Location = new System.Drawing.Point(16, 402);
            this.msktimngaybd.Mask = "00/00/0000";
            this.msktimngaybd.Name = "msktimngaybd";
            this.msktimngaybd.Size = new System.Drawing.Size(155, 26);
            this.msktimngaybd.TabIndex = 10;
            this.msktimngaybd.ValidatingType = typeof(System.DateTime);
            // 
            // txttimdiachi
            // 
            this.txttimdiachi.Location = new System.Drawing.Point(16, 290);
            this.txttimdiachi.Name = "txttimdiachi";
            this.txttimdiachi.Size = new System.Drawing.Size(155, 26);
            this.txttimdiachi.TabIndex = 12;
            // 
            // txttimtensukien
            // 
            this.txttimtensukien.Location = new System.Drawing.Point(16, 187);
            this.txttimtensukien.Name = "txttimtensukien";
            this.txttimtensukien.Size = new System.Drawing.Size(155, 26);
            this.txttimtensukien.TabIndex = 11;
            // 
            // txttimmasukien
            // 
            this.txttimmasukien.Location = new System.Drawing.Point(16, 81);
            this.txttimmasukien.Name = "txttimmasukien";
            this.txttimmasukien.Size = new System.Drawing.Size(155, 26);
            this.txttimmasukien.TabIndex = 10;
            // 
            // grthongtin
            // 
            this.grthongtin.Controls.Add(this.btnluu);
            this.grthongtin.Controls.Add(this.btnboqua);
            this.grthongtin.Controls.Add(this.btnsua);
            this.grthongtin.Controls.Add(this.btnxoa);
            this.grthongtin.Controls.Add(this.btnthem);
            this.grthongtin.Controls.Add(this.mskthongtinngaykt);
            this.grthongtin.Controls.Add(this.mskthongtinngaybd);
            this.grthongtin.Controls.Add(this.txtthongtindiachi);
            this.grthongtin.Controls.Add(this.txtthongtintensukien);
            this.grthongtin.Controls.Add(this.txtthongtinmasukien);
            this.grthongtin.Controls.Add(this.label5);
            this.grthongtin.Controls.Add(this.label4);
            this.grthongtin.Controls.Add(this.label3);
            this.grthongtin.Controls.Add(this.label2);
            this.grthongtin.Controls.Add(this.label1);
            this.grthongtin.Location = new System.Drawing.Point(348, 26);
            this.grthongtin.Name = "grthongtin";
            this.grthongtin.Size = new System.Drawing.Size(802, 244);
            this.grthongtin.TabIndex = 1;
            this.grthongtin.TabStop = false;
            this.grthongtin.Text = "Thông tin";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(702, 187);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(81, 37);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(553, 187);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(81, 37);
            this.btnboqua.TabIndex = 11;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(400, 187);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 37);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(216, 187);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(81, 37);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 187);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 37);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // mskthongtinngaykt
            // 
            this.mskthongtinngaykt.Location = new System.Drawing.Point(537, 136);
            this.mskthongtinngaykt.Mask = "00/00/0000";
            this.mskthongtinngaykt.Name = "mskthongtinngaykt";
            this.mskthongtinngaykt.Size = new System.Drawing.Size(246, 26);
            this.mskthongtinngaykt.TabIndex = 9;
            this.mskthongtinngaykt.ValidatingType = typeof(System.DateTime);
            // 
            // mskthongtinngaybd
            // 
            this.mskthongtinngaybd.Location = new System.Drawing.Point(162, 136);
            this.mskthongtinngaybd.Mask = "00/00/0000";
            this.mskthongtinngaybd.Name = "mskthongtinngaybd";
            this.mskthongtinngaybd.Size = new System.Drawing.Size(238, 26);
            this.mskthongtinngaybd.TabIndex = 8;
            this.mskthongtinngaybd.ValidatingType = typeof(System.DateTime);
            // 
            // txtthongtindiachi
            // 
            this.txtthongtindiachi.Location = new System.Drawing.Point(162, 81);
            this.txtthongtindiachi.Name = "txtthongtindiachi";
            this.txtthongtindiachi.Size = new System.Drawing.Size(621, 26);
            this.txtthongtindiachi.TabIndex = 7;
            // 
            // txtthongtintensukien
            // 
            this.txtthongtintensukien.Location = new System.Drawing.Point(537, 28);
            this.txtthongtintensukien.Name = "txtthongtintensukien";
            this.txtthongtintensukien.Size = new System.Drawing.Size(246, 26);
            this.txtthongtintensukien.TabIndex = 6;
            // 
            // txtthongtinmasukien
            // 
            this.txtthongtinmasukien.Location = new System.Drawing.Point(162, 26);
            this.txtthongtinmasukien.Name = "txtthongtinmasukien";
            this.txtthongtinmasukien.Size = new System.Drawing.Size(246, 26);
            this.txtthongtinmasukien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sự kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa điểm tổ chức";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sự kiện";
            // 
            // dataGridViewsukien
            // 
            this.dataGridViewsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsukien.Location = new System.Drawing.Point(348, 276);
            this.dataGridViewsukien.Name = "dataGridViewsukien";
            this.dataGridViewsukien.RowHeadersWidth = 62;
            this.dataGridViewsukien.RowTemplate.Height = 28;
            this.dataGridViewsukien.Size = new System.Drawing.Size(802, 296);
            this.dataGridViewsukien.TabIndex = 2;
            this.dataGridViewsukien.Click += new System.EventHandler(this.dataGridViewsukien_Click);
            // 
            // sukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 656);
            this.Controls.Add(this.dataGridViewsukien);
            this.Controls.Add(this.grthongtin);
            this.Controls.Add(this.grtimkiem);
            this.Name = "sukien";
            this.Text = "Sự kiện";
            this.Load += new System.EventHandler(this.sukien_Load);
            this.grtimkiem.ResumeLayout(false);
            this.grtimkiem.PerformLayout();
            this.grthongtin.ResumeLayout(false);
            this.grthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsukien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grtimkiem;
        private System.Windows.Forms.GroupBox grthongtin;
        private System.Windows.Forms.DataGridView dataGridViewsukien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtthongtinmasukien;
        private System.Windows.Forms.MaskedTextBox msktimngaykt;
        private System.Windows.Forms.MaskedTextBox msktimngaybd;
        private System.Windows.Forms.TextBox txttimdiachi;
        private System.Windows.Forms.TextBox txttimtensukien;
        private System.Windows.Forms.TextBox txttimmasukien;
        private System.Windows.Forms.MaskedTextBox mskthongtinngaykt;
        private System.Windows.Forms.MaskedTextBox mskthongtinngaybd;
        private System.Windows.Forms.TextBox txtthongtindiachi;
        private System.Windows.Forms.TextBox txtthongtintensukien;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.CheckBox chktheothoigian;
        private System.Windows.Forms.CheckBox chkdiachi;
        private System.Windows.Forms.CheckBox chktensukien;
        private System.Windows.Forms.CheckBox chkmasukien;
    }
}