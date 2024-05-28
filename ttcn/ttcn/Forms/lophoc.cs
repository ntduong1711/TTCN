using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ttcn.Class;

namespace ttcn
{
    public partial class lophoc : Form
    {
        public lophoc()
        {
            InitializeComponent();
        }

        private void lophoc_Load(object sender, EventArgs e)
        {
            load_gridview();
            
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtthongtinmalop.Enabled = false;
            txtmalop.Enabled = false;
            txttenlop.Enabled = false;
            txtphong.Enabled = false;
            mskngaybatdau.Enabled = false;
            mskngayketthuc.Enabled=false;

            Class.functions.fillCombo("select mamon,tenmon from tblmonhoc", cbothongtinmonhoc,
                "mamon", "tenmon");

        }
        DataTable tblophoc;
        
        private void load_gridview()
        {
            string sql;
            sql = "select * from tbllophoc";
            tblophoc = Class.functions.getdatatotable(sql);
            dataGridViewlop.DataSource = tblophoc;
            dataGridViewlop.AllowUserToAddRows = false;
            dataGridViewlop.EditMode = DataGridViewEditMode.EditProgrammatically;

        }


        private void dataGridViewlop_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi");
                return;
            }
            if (tblophoc.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu trong bang");
                return;
            }
            txtthongtinmalop.Text = dataGridViewlop.CurrentRow.Cells[0].Value.ToString();
            txtthongtintenlop.Text = dataGridViewlop.CurrentRow.Cells[1].Value.ToString();
            txtthongtinphonghoc.Text = dataGridViewlop.CurrentRow.Cells[3].Value.ToString();
            txtthongtinsiso.Text = dataGridViewlop.CurrentRow.Cells[2].Value.ToString();
            mskthongtinngaybd.Text = dataGridViewlop.CurrentRow.Cells[4].Value.ToString();
            mskthongtinngaykt.Text = dataGridViewlop.CurrentRow.Cells[5].Value.ToString();
            string ma;
            ma = dataGridViewlop.CurrentRow.Cells[6].Value.ToString();
            cbothongtinmonhoc.Text = Class.functions.getfieldvalue
                ("select tenmon from tblmonhoc where mamon=N'"+ma+"'");

        }


        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tbllophoc where 1=1";
            if (chktimmalop.Checked == true)
            {

                if (txtmalop.Text == "")
                {
                    MessageBox.Show("Can dien ma lop");
                }
                else
                    sql = sql + " AND malophoc = N'" + txtmalop.Text + "'";

            }
            if (chktimtenlop.Checked == true)
            {
                if (txttenlop.Text == "")
                {
                    MessageBox.Show("Can dien ten lop");
                }
                else
                    sql = sql + " AND tenlophoc Like N'%" + txttenlop.Text + "%'";

            }
           
            if(chktimphong.Checked == true)
            {
                if (txtphong.Text == "")
                {
                    MessageBox.Show("Ban can nhap phong hoc");
                    return;
                }
                else
                    sql = sql + " and phonghoc=N'"+txtphong.Text+"'";
            }
            if(chktimtheothoigian.Checked==true)
            {
                if (mskngaybatdau.Text == "  /  /")
                {
                    MessageBox.Show("Chon ngay bat dau");
                    return;
                }
                else
                {
                    if (mskngayketthuc.Text == "  /  /")
                    {
                        MessageBox.Show("Chon ngay ket thuc");
                        return;
                    }
                    else
                        sql = sql + "AND (ngaybatdau>='"+Class.functions.convertdatetime(mskngaybatdau.Text)+
                            "' and ngayketthuc<='"+Class.functions.convertdatetime(mskngayketthuc.Text)+"')";
                }
                
            }
            tblophoc = Class.functions.getdatatotable(sql);
            if (tblophoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo");
            }
            else
                MessageBox.Show("Có " + tblophoc.Rows.Count + " bản ghi thỏa mãn điều kiện", "Thông báo");
            dataGridViewlop.DataSource = tblophoc;
        }

        private void chktimmalop_Click(object sender, EventArgs e)
        {
            if(chktimmalop.Checked==true)
            {
                txtmalop.Enabled = true;
                txtmalop.Focus();
            }
            else
                txtmalop.Enabled=false;
        }

        private void chktimtenlop_Click(object sender, EventArgs e)
        {
            if (chktimtenlop.Checked == true)
            {
                txttenlop.Enabled = true;
                txttenlop.Focus();
            }
            else
                txttenlop.Enabled = false;
        }

        private void chktimphong_Click(object sender, EventArgs e)
        {
            if (chktimphong.Checked == true)
            {
                txtphong.Enabled = true;
                txtphong.Focus();
            }
            else
                txtphong.Enabled = false;
        }

        private void chktimtheothoigian_Click(object sender, EventArgs e)
        {
            if (chktimtheothoigian.Checked == true)
            {
                mskngaybatdau.Enabled = true;
                mskngayketthuc.Enabled = true;
            }
            else
            {
                mskngaybatdau.Enabled = false;
                mskngayketthuc.Enabled = false;
            }
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            chktimmalop.Checked = false;
            chktimtenlop.Checked = false;
            chktimphong.Checked = false;
            chktimtheothoigian.Checked = false;

            txtmalop.Enabled = false;
            txttenlop.Enabled = false;
            txtphong.Enabled = false;
            mskngaybatdau.Enabled=false;
            mskngayketthuc.Enabled=false;
        }


        private void reset()
        {
            txtthongtinmalop.Text = "";
            txtthongtintenlop.Text = "";
            txtthongtinphonghoc.Text = "";
            txtthongtinsiso.Text = "";
            mskthongtinngaybd.Text = "  /  /";
            mskthongtinngaykt.Text = "  /  /";
            cbothongtinmonhoc.Text = "";
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            txtthongtinmalop.Enabled = true;
            txtthongtinmalop.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtthongtinmalop.Text=="")
            {
                MessageBox.Show("ban can dien ma lop");
                return;
            }
            if (txtthongtintenlop.Text == "")
            {
                MessageBox.Show("ban can dien ten lop");
                return;
            }
            if (txtthongtinphonghoc.Text == "")
            {
                MessageBox.Show("ban can dien phong hoc");
                return;
            }
            if (txtthongtinsiso.Text == "")
            {
                MessageBox.Show("ban can dien so luong hoc vien toi da");
                return;
            }
            if (mskthongtinngaybd.Text == "  /  /")
            {
                MessageBox.Show("ban can dien ngay bat dau");
                return;
            }
            if (mskthongtinngaykt.Text == "  /  /")
            {
                MessageBox.Show("ban can dien ngay ket thuc");
                return;
            }
            if(cbothongtinmonhoc.Text=="")
            {
                MessageBox.Show("Ban can chon mon hoc");
                return;
            }
            sql = "select malophoc from tbllophoc where malophoc='"+txtthongtinmalop.Text+"'";
            if (Class.functions.checkey(sql) == true)
            {
                MessageBox.Show("Đã có mã học viên trong cơ sở dữ liệu!");
                txtthongtinmalop.Text = "";
                txtthongtinmalop.Focus();
                return;
            }
            if(MessageBox.Show("Ban co chac chan muon them du lieu lop hoc khong?","Thong bao",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = "insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon)" +
                " values ('" + txtthongtinmalop.Text + "',N'" + txtthongtintenlop.Text +
                "'," + txtthongtinsiso.Text + ",'" + txtthongtinphonghoc.Text + "'," +
                "'" + Class.functions.convertdatetime(mskthongtinngaybd.Text) +
                "','" + Class.functions.convertdatetime(mskthongtinngaykt.Text) +
                "','" + cbothongtinmonhoc.SelectedValue.ToString() + "')";
                Class.functions.runsql(sql);
                load_gridview();
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblophoc.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu");
                return;
            }
            if (txtthongtinmalop.Text == "")
            {
                MessageBox.Show("Chon hoc vien can xoa");
                return;
            }

            if (MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                string sql;
                sql = "delete tbllophoc where malophoc='" + txtthongtinmalop.Text + "'";
                Class.functions.RunSqlDel(sql);
                load_gridview();
                reset();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            if (txtthongtinmalop.Text == "")
            {
                MessageBox.Show("ban can dien ma lop");
                return;
            }
            if (txtthongtintenlop.Text == "")
            {
                MessageBox.Show("ban can dien ten lop");
                return;
            }
            if (txtthongtinphonghoc.Text == "")
            {
                MessageBox.Show("ban can dien phong hoc");
                return;
            }
            if (txtthongtinsiso.Text == "")
            {
                MessageBox.Show("ban can dien so luong hoc vien toi da");
                return;
            }
            if (mskthongtinngaybd.Text == "  /  /")
            {
                MessageBox.Show("ban can dien ngay bat dau");
                return;
            }
            if (mskthongtinngaykt.Text == "  /  /")
            {
                MessageBox.Show("ban can dien ngay ket thuc");
                return;
            }
            if (cbothongtinmonhoc.Text == "")
            {
                MessageBox.Show("Ban can chon mon hoc");
                return;
            }
            if (MessageBox.Show("Ban co chac chan muon sua du lieu khong?", "thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql;

                sql = "update tbllophoc set tenlophoc=N'"+txtthongtintenlop.Text+"'," +
                    "sisomax="+txtthongtinsiso.Text+",phonghoc=N'"+txtthongtinphonghoc.Text+
                    "',ngaybatdau='"+Class.functions.convertdatetime(mskthongtinngaybd.Text)+"'," +
                    "ngayketthuc='"+Class.functions.convertdatetime(mskthongtinngaykt.Text)+"'," +
                    "mamon='"+cbothongtinmonhoc.SelectedValue.ToString()+"'" +
                    " where malophoc='"+txtthongtinmalop.Text+"'";
                
                Class.functions.runsql(sql);
                load_gridview();
                reset();
            }
            btnboqua.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled=true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtthongtinmalop.Enabled = false;
        }

        private void btnxemall_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tbllophoc";
            Class.functions.runsql(sql);
            load_gridview();
        }
    }
}
