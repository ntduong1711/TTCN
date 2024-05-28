namespace ttcn
{
    partial class menu_qlyhv
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hocVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kyHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hocVienToolStripMenuItem,
            this.lớpHọcToolStripMenuItem,
            this.kyHocToolStripMenuItem,
            this.suToolStripMenuItem,
            this.phiếuChiToolStripMenuItem,
            this.xếpLớpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hocVienToolStripMenuItem
            // 
            this.hocVienToolStripMenuItem.Name = "hocVienToolStripMenuItem";
            this.hocVienToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.hocVienToolStripMenuItem.Text = "Học viên";
            this.hocVienToolStripMenuItem.Click += new System.EventHandler(this.hocVienToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
            // 
            // kyHocToolStripMenuItem
            // 
            this.kyHocToolStripMenuItem.Name = "kyHocToolStripMenuItem";
            this.kyHocToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.kyHocToolStripMenuItem.Text = "Kỳ học";
            this.kyHocToolStripMenuItem.Click += new System.EventHandler(this.kyHocToolStripMenuItem_Click);
            // 
            // suToolStripMenuItem
            // 
            this.suToolStripMenuItem.Name = "suToolStripMenuItem";
            this.suToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.suToolStripMenuItem.Text = "Sự kiện";
            this.suToolStripMenuItem.Click += new System.EventHandler(this.suToolStripMenuItem_Click);
            // 
            // phiếuChiToolStripMenuItem
            // 
            this.phiếuChiToolStripMenuItem.Name = "phiếuChiToolStripMenuItem";
            this.phiếuChiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.phiếuChiToolStripMenuItem.Text = "Phiếu chi";
            this.phiếuChiToolStripMenuItem.Click += new System.EventHandler(this.phiếuChiToolStripMenuItem_Click);
            // 
            // xếpLớpToolStripMenuItem
            // 
            this.xếpLớpToolStripMenuItem.Name = "xếpLớpToolStripMenuItem";
            this.xếpLớpToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.xếpLớpToolStripMenuItem.Text = "Xếp lớp";
            this.xếpLớpToolStripMenuItem.Click += new System.EventHandler(this.xếpLớpToolStripMenuItem_Click);
            // 
            // menu_qlyhv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu_qlyhv";
            this.Text = "menu_qlyhv";
            this.Load += new System.EventHandler(this.menu_qlyhv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hocVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kyHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpLớpToolStripMenuItem;
    }
}