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
using ttcn.Class;

namespace ttcn
{
    public partial class hocvien : Form
    {
        public hocvien()
        {
            InitializeComponent();
        }

        private void hocvien_Load(object sender, EventArgs e)
        {
            load_gridview();
            txtmahocvien.Enabled = false;
            txttenhocvien.Enabled = false;
            cbomonhoc.Enabled = false;
            rdoalto.Enabled = false;
            rdobaritone.Enabled = false;
            rdobass.Enabled = false;
            rdosoprano.Enabled = false;
            rdotenor.Enabled = false;
            rdocap1.Enabled = false;
            rdocap2.Enabled = false;
            rdocap3.Enabled = false;

            txtthongtinmahv.Enabled = false;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.BackColor = Color.Gray;
            btnluu.BackColor = Color.Gray;
        }
        DataTable tbhocvien;
        private Color mycolor;
        private void load_gridview()
        {
            string sql;
            sql = "select * from tblhocvien";
            tbhocvien = Class.functions.getdatatotable(sql);
            dataGridViewhocvien.DataSource = tbhocvien;

            dataGridViewhocvien.AllowUserToAddRows = false;
            dataGridViewhocvien.EditMode = DataGridViewEditMode.EditProgrammatically;

            Class.functions.fillCombo("select mamon,tenmon from tblmonhoc", cbomonhoc, "mamon", "tenmon");
            cbomonhoc.SelectedIndex = -1;
            

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblhocvien where 1=1";
            if (chktimmahocvien.Checked == true)
            {

                if (txtmahocvien.Text == "")
                {
                    MessageBox.Show("Can dien ma hoc vien");
                    return;
                }
                else
                    sql = sql + " AND mahocvien = N'" + txtmahocvien.Text + "'";

            }
            if (chktimtenhocvien.Checked == true)
            {
                if (txttenhocvien.Text == "")
                {
                    MessageBox.Show("Can dien ten hoc vien");
                    return;
                }
                else
                    sql = sql + " AND tenhocvien Like N'%" + txttenhocvien.Text + "%'";

            }
            if (chktimtheocapdo.Checked == true)
            {
                if (rdocap1.Checked == false && rdocap2.Checked == false && rdocap3.Checked == false)
                {
                    MessageBox.Show("Can chon cap do");
                    return;
                }
                if (rdocap1.Checked == true)
                {
                    sql = sql + "AND capdo=" + rdocap1.Text + "";
                }
                if (rdocap2.Checked == true)
                {
                    sql = sql + "AND capdo=" + rdocap2.Text + "";
                }
                if (rdocap3.Checked == true)
                {
                    sql = sql + "AND capdo=" + rdocap3.Text + "";
                }
            }
            if (chktimtheoloaigiong.Checked == true)
            {
                if (rdoalto.Checked == false && rdobaritone.Checked == false && rdobass.Checked == false
                    && rdosoprano.Checked == false && rdotenor.Checked == false)
                {
                    MessageBox.Show("Chon loai giong");
                    return;
                }
                if (rdoalto.Checked == true)
                {
                    sql = sql + "AND loaigiong='" + rdoalto.Text + "'";
                }
                if (rdobaritone.Checked == true)
                {
                    sql = sql + "AND loaigiong='" + rdobaritone.Text + "'";
                }
                if (rdobass.Checked == true)
                {
                    sql = sql + "AND loaigiong='" + rdobass.Text + "'";
                }
                if (rdosoprano.Checked == true)
                {
                    sql = sql + "AND loaigiong='" + rdosoprano.Text + "'";
                }
                if (rdotenor.Checked == true)
                {
                    sql = sql + "AND loaigiong='" + rdotenor.Text + "'";
                }
            }
            if (chktimtheolop.Checked == true)
            {
                if (cbomonhoc.Text == "")
                {
                    MessageBox.Show("Chon mon hoc");
                    return;
                }
                else
                {
                    sql = "";
                    sql = "select tblhocvien.mahocvien,tenhocvien,tblhocvien.loaigiong," +
                        "tblhocvien.capdo,gioitinh,sodienthoai,email,ngaysinh,diachi from tblhocvien" +
                        " inner join tblthamgia on tblhocvien.mahocvien=tblthamgia.mahocvien" +
                        " inner join tbllophoc on tblthamgia.malophoc=tbllophoc.malophoc" +
                        " inner join tblmonhoc on tblmonhoc.mamon=tbllophoc.mamon" +
                        " where 1=1 and tbllophoc.mamon='"+cbomonhoc.SelectedValue.ToString()+"'";
                }
                    
            }
            tbhocvien = Class.functions.getdatatotable(sql);
            if (tbhocvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo");
            }
            else
                MessageBox.Show("Có " + tbhocvien.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo");
            dataGridViewhocvien.DataSource = tbhocvien;


        }

        private void chktimmahocvien_Click(object sender, EventArgs e)
        {
            if (chktimmahocvien.Checked == false)
                txtmahocvien.Enabled = false;
            else
                txtmahocvien.Enabled = true;
        }

        private void chktimtenhocvien_Click(object sender, EventArgs e)
        {
            if (chktimtenhocvien.Checked == false)
                txttenhocvien.Enabled = false;
            else
                txttenhocvien.Enabled = true;
        }

        private void chktimtheocapdo_Click(object sender, EventArgs e)
        {
            if (chktimtheocapdo.Enabled == true)
            {
                rdocap1.Enabled = true;
                rdocap2.Enabled = true;
                rdocap3.Enabled = true;

            }
            else
            {
                rdocap1.Enabled = false;
                rdocap2.Enabled = false;
                rdocap3.Enabled = false;
            }

        }

        private void chktimtheoloaigiong_Click(object sender, EventArgs e)
        {
            if (chktimtheoloaigiong.Checked == true)
            {
                rdobaritone.Enabled = true;
                rdoalto.Enabled = true;
                rdosoprano.Enabled = true;
                rdotenor.Enabled = true;
                rdobass.Enabled = true;
            }
            else
            {
                rdobaritone.Enabled = false;
                rdoalto.Enabled = false;
                rdosoprano.Enabled = false;
                rdotenor.Enabled = false;
                rdobass.Enabled = false;
            }
        }
        private void chktimtheolop_Click(object sender, EventArgs e)
        {
            if (chktimtheolop.Checked == true)
                cbomonhoc.Enabled = true;
            else
                cbomonhoc.Enabled = false;
        }

        private void dataGridViewhocvien_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi");
                return;
            }
            if (tbhocvien.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu trong bang");
                return;
            }
            txtthongtinmahv.Text = dataGridViewhocvien.CurrentRow.Cells["mahocvien"].Value.ToString();
            txtthongtintenhv.Text = dataGridViewhocvien.CurrentRow.Cells["tenhocvien"].Value.ToString();
            cbothongtincapdo.Text = dataGridViewhocvien.CurrentRow.Cells["capdo"].Value.ToString();
            cbothongtinloaigiong.Text = dataGridViewhocvien.CurrentRow.Cells["loaigiong"].Value.ToString();

            txtemail.Text = dataGridViewhocvien.CurrentRow.Cells["email"].Value.ToString();
            mskngaysinh.Text = dataGridViewhocvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            msksdt.Text = dataGridViewhocvien.CurrentRow.Cells["sodienthoai"].Value.ToString();
            txtdiachi.Text = dataGridViewhocvien.CurrentRow.Cells["diachi"].Value.ToString();

            if (Convert.ToBoolean(dataGridViewhocvien.CurrentRow.Cells["gioitinh"].Value) == true)

            {
                chkgtnu.Checked = true;
                chkgtnam.Checked = false;
            }
            else
            {
                chkgtnam.Checked = true;
                chkgtnu.Checked = false;
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;

        }
        private void reset()
        {
            rdocap1.Checked = false;
            rdocap2.Checked = false;
            rdocap3.Checked = false;
            rdosoprano.Checked = false;
            rdoalto.Checked = false;
            rdobass.Checked = false;
            rdotenor.Checked = false;
            rdobaritone.Checked = false;
            txtmahocvien.Text = "";
            txttenhocvien.Text = "";

            chktimmahocvien.Checked = false;
            chktimtenhocvien.Checked = false;
            chktimtheocapdo.Checked = false;
            chktimtheolop.Checked = false;
            chktimtheoloaigiong.Checked = false;


        }
        private void btnlamlai_Click(object sender, EventArgs e)
        {
            reset();
            chktimmahocvien.Checked = false;
            chktimtenhocvien.Checked = false;
            chktimtheocapdo.Checked = false;
            chktimtheoloaigiong.Checked = false;
            chktimtheolop.Checked = false;
            rdocap1.Enabled = false;
            rdocap2.Enabled = false;
            rdocap3.Enabled = false;
            rdosoprano.Enabled = false;
            rdoalto.Enabled = false;
            rdobass.Enabled = false;
            rdotenor.Enabled = false;
            rdobaritone.Enabled = false;
            txtmahocvien.Enabled = false;
            txttenhocvien.Enabled = false;
            cbomonhoc.Enabled = false;
        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            mycolor = btnthem.BackColor;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.BackColor = Color.Gray;
            btnsua.BackColor = Color.Gray;
            btnxoa.BackColor = Color.Gray;
            btnboqua.BackColor = mycolor;
            btnluu.BackColor = mycolor;
            txtthongtinmahv.Enabled = true;
            txtthongtinmahv.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (tbhocvien.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu");
                return;
            }
            if (txtthongtinmahv.Text == "")
            {
                MessageBox.Show("Chon hoc vien can xoa");
                return;
            }

            if (MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                string sql;
                sql = "delete tblhocvien where mahocvien='" + txtthongtinmahv.Text + "'";
                Class.functions.RunSqlDel(sql);
                load_gridview();
                resetvalue();
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            if (tbhocvien.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu trong bang");
            }
            if (txtthongtinmahv.Text == "")
            {
                MessageBox.Show("Chua chon ban ghi nao");
                return;
            }
            if (txtthongtintenhv.Text == "")
            {
                MessageBox.Show("Ban can dien ten hoc vien");
                return;
            }
           
            if (cbothongtinloaigiong.Text == "")
            {
                MessageBox.Show("Ban can chon loai giong");
                return;
            }
            if (cbothongtincapdo.Text == "")
            {
                MessageBox.Show("Ban can chon cap do");
                return;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Ban can dien email");
                return;

            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Ban can dien dia chi");
                return;
            }
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Ban can dien ngay sinh");
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Ban can dien ngay sinh");
                return;
            }
            int gt;
            if (chkgtnam.Checked == true)
            {
                gt = 0;
            }
            else
                gt = 1;
            if(MessageBox.Show("Ban co chac chan muon sua du lieu khong?","thong bao",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sql;
                
                string sdt = functions.removeMaskSDT(msksdt.Text);
                sql = "update tblhocvien set tenhocvien=N'" + txtthongtintenhv.Text + "',gioitinh=" + gt + "," +
                    " loaigiong=N'" + cbothongtinloaigiong.Text + "'," +
                    " capdo='" + cbothongtincapdo.Text + "'," +
                    " sodienthoai='" + sdt + "'," +
                    " email=N'" + txtemail.Text + "',ngaysinh='" +Class.functions.convertdatetime( mskngaysinh.Text)
                    + "'," +"diachi=N'" + txtdiachi.Text + "'," +
                    "' where mahocvien='" + txtthongtinmahv.Text + "'";
                MessageBox.Show(sql);
                Class.functions.runsql(sql);
                load_gridview();
                resetvalue();
            }
            btnboqua.Enabled = false;
            btnboqua.BackColor = Color.Gray;
        }
        private void resetvalue()
        {
            txtthongtinmahv.Text = "";
            txtthongtintenhv.Text = "";
            chkgtnam.Checked = false;
            chkgtnu.Checked = false;
            txtdiachi.Text = "";
            txtemail.Text = "";
            cbothongtincapdo.Text = "";
            cbothongtinloaigiong.Text = "";
            //cbothongtinlophoc.Text = "";
            mskngaysinh.Text = "  /  /";
            msksdt.Text = "(   )    -";

        }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            txtthongtinmahv.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtthongtinmahv.Text=="")
            {
                MessageBox.Show("ban can dien ma hoc vien");
                return;
            }
            if(txtthongtintenhv.Text=="")
            {
                MessageBox.Show("Ban can dien ten hoc vien");
                return;
            }
            if(msksdt.Text== "(   )    -")
            {
                MessageBox.Show("Ban can dien so dien thoai");
                return;
            }
            if(mskngaysinh.Text== "  /  /")
            {
                MessageBox.Show("Ban can dien ngay sinh");
                return;
            }
            if (cbothongtincapdo.Text == "")
            {
                MessageBox.Show("Ban can chon cap do");
                return;
            }
            if(cbothongtinloaigiong.Text=="")
            {
                MessageBox.Show("Ban can chon loai giong");
                return;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Ban can dien email");
                return;
            }
            sql = "select mahocvien from tblhocvien where mahocvien='"+txtthongtinmahv.Text+"'";
            if (Class.functions.checkey(sql) == true)
            {
                MessageBox.Show("Đã có mã học viên trong cơ sở dữ liệu!");
                txtthongtinmahv.Text = "";
                txtthongtinmahv.Focus();
                return;
            }
            int gt;
            if (chkgtnam.Checked == true)
            {
                gt = 0;
            }
            else
                gt = 1;

            string sdt = functions.removeMaskSDT(msksdt.Text);
            string ngaysinh = Class.functions.convertdatetime(mskngaysinh.Text);
            if (MessageBox.Show("Ban co chac chan muon them du lieu khong?","Thong bao",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) " +
                    " values ('"+txtthongtinmahv.Text+"', N'"+txtthongtintenhv.Text+"', " +
                    ""+gt+", '"+cbothongtinloaigiong.Text+"', "+cbothongtincapdo.Text+"" +
                    ", '"+sdt+"', " +
                    "'"+txtemail.Text+"', " +
                    "'"+ngaysinh+"', N'"+txtdiachi.Text+"','"+"')";
                Class.functions.runsql(sql);
                load_gridview();
            }
        }

        private void btnxemall_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblhocvien";
            Class.functions.runsql(sql);
            load_gridview();
        }
    }
}
