using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ttcn
{
    public partial class menu_qlyhv : Form
    {
        public menu_qlyhv()
        {
            InitializeComponent();
        }

        private void menu_qlyhv_Load(object sender, EventArgs e)
        {
            Class.functions.connect();
        }

        private void hocVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttcn.hocvien frmhocvien=new ttcn.hocvien();
            frmhocvien.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            ttcn.lophoc frmlophoc=new ttcn.lophoc();
            frmlophoc.Show();
        }

        private void kyHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttcn.kyhoc frmkyhoc=new ttcn.kyhoc();
            frmkyhoc.Show();
        }

        private void suToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttcn.Forms.sukien frmsukien=new ttcn.Forms.sukien();
            frmsukien.Show();
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttcn.Forms.phieuchi frmphieuchi=new Forms.phieuchi();
            frmphieuchi.Show();
        }

        private void xếpLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttcn.Forms.xeplop frmxeplop=new ttcn.Forms.xeplop();
            frmxeplop.Show();
        }
    }
}
