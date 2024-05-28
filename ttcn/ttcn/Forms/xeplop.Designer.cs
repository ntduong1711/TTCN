namespace ttcn.Forms
{
    partial class xeplop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.mskngayketthuc = new System.Windows.Forms.MaskedTextBox();
            this.listhocvien = new System.Windows.Forms.ListBox();
            this.mskngaybatdau = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhienthilop = new System.Windows.Forms.Button();
            this.cbolophoc = new System.Windows.Forms.ComboBox();
            this.listthanhvienlop = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnhienthi);
            this.groupBox1.Controls.Add(this.mskngayketthuc);
            this.groupBox1.Controls.Add(this.listhocvien);
            this.groupBox1.Controls.Add(this.mskngaybatdau);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(314, 42);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(95, 33);
            this.btnhienthi.TabIndex = 4;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // mskngayketthuc
            // 
            this.mskngayketthuc.Location = new System.Drawing.Point(24, 96);
            this.mskngayketthuc.Mask = "00/00/0000";
            this.mskngayketthuc.Name = "mskngayketthuc";
            this.mskngayketthuc.Size = new System.Drawing.Size(159, 26);
            this.mskngayketthuc.TabIndex = 3;
            this.mskngayketthuc.ValidatingType = typeof(System.DateTime);
            // 
            // listhocvien
            // 
            this.listhocvien.FormattingEnabled = true;
            this.listhocvien.ItemHeight = 20;
            this.listhocvien.Location = new System.Drawing.Point(24, 141);
            this.listhocvien.Name = "listhocvien";
            this.listhocvien.Size = new System.Drawing.Size(474, 464);
            this.listhocvien.TabIndex = 1;
            this.listhocvien.DoubleClick += new System.EventHandler(this.listhocvien_DoubleClick);
            // 
            // mskngaybatdau
            // 
            this.mskngaybatdau.Location = new System.Drawing.Point(24, 45);
            this.mskngaybatdau.Mask = "00/00/0000";
            this.mskngaybatdau.Name = "mskngaybatdau";
            this.mskngaybatdau.Size = new System.Drawing.Size(159, 26);
            this.mskngaybatdau.TabIndex = 2;
            this.mskngaybatdau.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnhienthilop);
            this.groupBox2.Controls.Add(this.cbolophoc);
            this.groupBox2.Controls.Add(this.listthanhvienlop);
            this.groupBox2.Location = new System.Drawing.Point(561, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 639);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnhienthilop
            // 
            this.btnhienthilop.Location = new System.Drawing.Point(566, 23);
            this.btnhienthilop.Name = "btnhienthilop";
            this.btnhienthilop.Size = new System.Drawing.Size(95, 33);
            this.btnhienthilop.TabIndex = 5;
            this.btnhienthilop.Text = "Hiển thị";
            this.btnhienthilop.UseVisualStyleBackColor = true;
            this.btnhienthilop.Click += new System.EventHandler(this.btnhienthilop_Click);
            // 
            // cbolophoc
            // 
            this.cbolophoc.FormattingEnabled = true;
            this.cbolophoc.Location = new System.Drawing.Point(32, 28);
            this.cbolophoc.Name = "cbolophoc";
            this.cbolophoc.Size = new System.Drawing.Size(195, 28);
            this.cbolophoc.TabIndex = 1;
            // 
            // listthanhvienlop
            // 
            this.listthanhvienlop.FormattingEnabled = true;
            this.listthanhvienlop.ItemHeight = 20;
            this.listthanhvienlop.Location = new System.Drawing.Point(32, 141);
            this.listthanhvienlop.Name = "listthanhvienlop";
            this.listthanhvienlop.Size = new System.Drawing.Size(629, 464);
            this.listthanhvienlop.TabIndex = 0;
            this.listthanhvienlop.DoubleClick += new System.EventHandler(this.listthanhvienlop_DoubleClick);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(1145, 677);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 35);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // xeplop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 724);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "xeplop";
            this.Text = "xeplop";
            this.Load += new System.EventHandler(this.xeplop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listhocvien;
        private System.Windows.Forms.ComboBox cbolophoc;
        private System.Windows.Forms.ListBox listthanhvienlop;
        private System.Windows.Forms.MaskedTextBox mskngayketthuc;
        private System.Windows.Forms.MaskedTextBox mskngaybatdau;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnhienthilop;
        private System.Windows.Forms.Button btnluu;
    }
}