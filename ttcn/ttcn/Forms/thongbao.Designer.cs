namespace ttcn.Forms
{
    partial class thongbao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txttieude = new System.Windows.Forms.TextBox();
            this.mskngaygui = new System.Windows.Forms.MaskedTextBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbonhanvien = new System.Windows.Forms.ComboBox();
            this.dataGridViewthongbao = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongbao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thông báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày gửi";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(157, 25);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(149, 26);
            this.txtma.TabIndex = 3;
            // 
            // txttieude
            // 
            this.txttieude.Location = new System.Drawing.Point(425, 25);
            this.txttieude.Name = "txttieude";
            this.txttieude.Size = new System.Drawing.Size(490, 26);
            this.txttieude.TabIndex = 4;
            // 
            // mskngaygui
            // 
            this.mskngaygui.Location = new System.Drawing.Point(157, 92);
            this.mskngaygui.Mask = "00/00/0000";
            this.mskngaygui.Name = "mskngaygui";
            this.mskngaygui.Size = new System.Drawing.Size(149, 26);
            this.mskngaygui.TabIndex = 5;
            this.mskngaygui.ValidatingType = typeof(System.DateTime);
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(425, 197);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(495, 276);
            this.txtnoidung.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người gửi";
            // 
            // cbonhanvien
            // 
            this.cbonhanvien.FormattingEnabled = true;
            this.cbonhanvien.Location = new System.Drawing.Point(425, 90);
            this.cbonhanvien.Name = "cbonhanvien";
            this.cbonhanvien.Size = new System.Drawing.Size(219, 28);
            this.cbonhanvien.TabIndex = 8;
            // 
            // dataGridViewthongbao
            // 
            this.dataGridViewthongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthongbao.Location = new System.Drawing.Point(28, 197);
            this.dataGridViewthongbao.Name = "dataGridViewthongbao";
            this.dataGridViewthongbao.RowHeadersWidth = 62;
            this.dataGridViewthongbao.RowTemplate.Height = 28;
            this.dataGridViewthongbao.Size = new System.Drawing.Size(360, 276);
            this.dataGridViewthongbao.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(28, 494);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(103, 40);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(817, 494);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(103, 40);
            this.btngui.TabIndex = 11;
            this.btngui.Text = "Gửi";
            this.btngui.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(176, 494);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(103, 40);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(331, 494);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(103, 40);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(489, 494);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(103, 40);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(651, 494);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(103, 40);
            this.btnboqua.TabIndex = 15;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // thongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 564);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewthongbao);
            this.Controls.Add(this.cbonhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.mskngaygui);
            this.Controls.Add(this.txttieude);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "thongbao";
            this.Text = "Thông báo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongbao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txttieude;
        private System.Windows.Forms.MaskedTextBox mskngaygui;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbonhanvien;
        private System.Windows.Forms.DataGridView dataGridViewthongbao;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
    }
}