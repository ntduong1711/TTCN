using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttcn
{
    public partial class kyhoc : Form
    {
        public kyhoc()
        {
            InitializeComponent();
        }

        private void kyhoc_Load(object sender, EventArgs e)
        {
            load_gridview();
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtthongtinmaky.Enabled = false;    
        }
        DataTable tbkyhoc;
        private Color mycolor;
        private void load_gridview()
        {
            string sql;
            sql = "select * from kyhoc";
            tbkyhoc = Class.functions.getdatatotable(sql);
            dataGridViewky.DataSource = tbkyhoc;

            dataGridViewky.Columns[0].Width = 80;
            dataGridViewky.Columns[1].Width = 80;
            dataGridViewky.Columns[2].Width = 80;

            dataGridViewky.AllowUserToAddRows = false;
            dataGridViewky.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
       
        private void btnlamlai_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("okok");
        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from kyhoc where 1=1";
            if (chktimmaky.Checked == true)
            {

                if (txtmaky.Text == "")
                {
                    MessageBox.Show("Can dien ma ky hoc");
                }
                else
                    sql = sql + " AND makyhoc = N'" + txtmaky.Text + "'";

            }
            if (chktimtenky.Checked == true)
            {
                if (txttenky.Text == "")
                {
                    MessageBox.Show("Can dien ten ky");
                }
                else
                    sql = sql + " AND kyhoc = " + txttenky.Text + "";
            }
            if (chktimtheonam.Checked == true)
            {
                if (txtnam.Text == "")
                {
                    MessageBox.Show("Can dien nam");
                }
                else
                    sql = sql + " AND namhoc = " + txtnam.Text + "";
            }
            tbkyhoc = Class.functions.getdatatotable(sql);
            if (tbkyhoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo");
            }
            else
                MessageBox.Show("Có " + tbkyhoc.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo");
            dataGridViewky.DataSource = tbkyhoc;
        }

        private void dataGridViewky_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi");
                return;
            }
            if (tbkyhoc.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu trong bang");
                return;
            }
            txtthongtinmaky.Text = dataGridViewky.CurrentRow.Cells["makyhoc"].Value.ToString();
            txtthongtintenky.Text = dataGridViewky.CurrentRow.Cells["kyhoc"].Value.ToString();
            txtthongtinnam.Text = dataGridViewky.CurrentRow.Cells["namhoc"].Value.ToString();

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.BackColor = mycolor;
            btnxoa.BackColor=mycolor;
            btnboqua.BackColor=mycolor;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            mycolor=btnthem.BackColor;
            btnthem.Enabled=false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled=false;
            txtthongtinmaky.Enabled = true;
            txtthongtinmaky.Focus();
            btnthem.BackColor = Color.Gray;
            btnsua.BackColor = Color.Gray;
            btnxoa.BackColor = Color.Gray;
            btnboqua.BackColor = mycolor;
        }
        private void reset()
        {
            txtthongtinmaky.Text = "";
            txtthongtinnam.Text = "";
            txtthongtintenky.Text = "";

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtthongtinmaky.Enabled=false;
            btnthem.BackColor = mycolor;
            btnsua.BackColor = mycolor;
            btnxoa.BackColor = mycolor;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tbkyhoc.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu");
                return;
            }
            if (txtthongtinmaky.Text == "")
            {
                MessageBox.Show("Chon hoc vien can xoa");
                return;
            }

            if (MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                string sql;
                sql = "delete hocvien where mahocvien='" + txtthongtinmaky.Text + "'";
                Class.functions.RunSqlDel(sql);
                load_gridview();
                reset();
            }
            
        }
    }
}
