using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttcn.Forms
{
    public partial class sukien : Form
    {
        public sukien()
        {
            InitializeComponent();
        }

        private void sukien_Load(object sender, EventArgs e)
        {
            load_datagridview();
            txttimmasukien.Enabled = false;
            txttimtensukien.Enabled=false;
            txttimdiachi.Enabled = false;   
            msktimngaybd.Enabled = false;
            msktimngaykt.Enabled=false;

            chkmasukien.Checked=false;
            chktensukien.Checked=false;
            chktheothoigian.Checked=false;
            chkdiachi.Checked=false;

            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtthongtinmasukien.Enabled = false;
        }
        DataTable tbskien;
        private void load_datagridview()
        {
            string sql;
            sql = "select * from tblsukien";
            tbskien=Class.functions.getdatatotable(sql);
            dataGridViewsukien.DataSource= tbskien;
            dataGridViewsukien.AllowUserToAddRows = false;
            dataGridViewsukien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridViewsukien_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo");
            }
            if (tbskien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng", "Thông báo");
            }

            txtthongtinmasukien.Text = dataGridViewsukien.CurrentRow.Cells[0].Value.ToString();
            txtthongtintensukien.Text = dataGridViewsukien.CurrentRow.Cells[1].Value.ToString();
            txtthongtindiachi.Text = dataGridViewsukien.CurrentRow.Cells[4].Value.ToString();
            mskthongtinngaybd.Text = dataGridViewsukien.CurrentRow.Cells[2].Value.ToString();
            mskthongtinngaykt.Text = dataGridViewsukien.CurrentRow.Cells[3].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblsukien where 1=1  ";
            if (chkmasukien.Checked == true)
            {
                if (txttimmasukien.Text == "")
                {
                    MessageBox.Show("Bạn cần điền mã sự kiện cần tìm");
                    return;
                }
                else
                    sql = sql+ " and masukien like '%"+txttimmasukien.Text+"% '";
            }
            if (chktensukien.Checked == true)
            {
                if (txttimtensukien.Text == "")
                {
                    MessageBox.Show("Bạn cần điền tên sự kiện cần tìm");
                    return;
                }
                else
                    sql = sql+ " and tensukien like N'%"+txttimtensukien.Text+"%'";
            }
            if (chkdiachi.Checked == true)
            {
                if (txttimdiachi.Text == "")
                {
                    MessageBox.Show("Bạn cần điền địa điểm tổ chức sự kiện cần tìm");
                    return;
                }
                else
                    sql = sql+ " and diadiemtochuc like N'%"+txttimdiachi.Text+"%'";
            }
            if (chktheothoigian.Checked == true)
            {
                if (msktimngaybd.Text== "  /  /"&&msktimngaykt.Text== "  /  /")
                {
                    MessageBox.Show("Bạn cần điền thời gian tổ chức sự kiện cần tìm");
                    return;
                }
                else
                {
                    if (msktimngaybd.Text != "  /  /")
                    {
                        sql = sql + " and ngaybatdau>='" + Class.functions.convertdatetime(msktimngaybd.Text) +"'";
                    }
                        
                    else
                        sql = sql + " and ngayketthuc<='"+Class.functions.convertdatetime(msktimngaykt.Text) +"' ";
                }
            }
            tbskien = Class.functions.getdatatotable(sql);
            if (tbskien.Rows.Count == 0)
            {
                MessageBox.Show("Không có sự kiện phù hợp");
            }
            else
                MessageBox.Show("Có " + tbskien.Rows.Count + " bản ghi phù hợp");
            dataGridViewsukien.DataSource = tbskien;
        }

        private void chkmasukien_Click(object sender, EventArgs e)
        {
            if (chkmasukien.Checked == true)
            {
                txttimmasukien.Enabled = true;
            }
            else
                txttimmasukien.Enabled=false;
        }

        private void chktensukien_Click(object sender, EventArgs e)
        {
            if (chktensukien.Checked == true)
            {
                txttimtensukien.Enabled = true;
            }
            else
                txttimtensukien.Enabled = false;
        }

        private void chkdiachi_Click(object sender, EventArgs e)
        {
            if (chkdiachi.Checked == true)
            {
                txttimdiachi.Enabled = true;
            }
            else
                txttimdiachi.Enabled = false;
        }

        private void chktheothoigian_Click(object sender, EventArgs e)
        {
            if (chktheothoigian.Checked == true)
            {
                msktimngaybd.Enabled = true;
                msktimngaykt.Enabled = true;
            }
            else
            {
                msktimngaybd.Enabled = false;
                msktimngaykt.Enabled=false;
            }
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txttimmasukien.Enabled = false;
            txttimtensukien.Enabled = false;
            txttimdiachi.Enabled = false;
            msktimngaybd.Enabled = false;
            msktimngaykt.Enabled = false;

            chkmasukien.Checked = false;
            chktensukien.Checked = false;
            chktheothoigian.Checked = false;
            chkdiachi.Checked = false;

            txttimmasukien.Text = "";
            txttimtensukien.Text = "";
            txttimdiachi.Text = "";
            msktimngaybd.Text = "  /  /";
            msktimngaykt.Text = "  /  /";
        }

        private void reset()
        {
            txtthongtinmasukien.Text = "";
            txtthongtintensukien.Text = "";
            txtthongtindiachi.Text = "";
            mskthongtinngaybd.Text = "  /  /";
            mskthongtinngaykt.Text = "  /  /";

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            reset();
            txtthongtinmasukien.Enabled = true;
            txtthongtinmasukien.Focus();
            btnboqua.Enabled = true;
            btnluu.Enabled=true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtthongtinmasukien.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbskien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu trong bảng");
                return;
            }
            if (txtthongtinmasukien.Text == "")
            {
                MessageBox.Show("Bạn cần chọn bản ghi cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                //string sql;
                sql = "delete tblsukien where maphieuchi='" + txtthongtinmasukien.Text + "'";
                Class.functions.RunSqlDel(sql);
                load_datagridview();
                reset();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tbskien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng");
                return;
            }
            if (txtthongtinmasukien.Text == "")
            {
                MessageBox.Show("Bạn cần chọn bản ghi cần sửa");
                return;
            }
            if(txtthongtintensukien.Text=="")
            {
                MessageBox.Show("Ban can dien ten su kien");
                return;
            }
            if (txtthongtindiachi.Text == "")
            {
                MessageBox.Show("Ban can dien dia chi su kien");
                return;
            }
            if(mskthongtinngaybd.Text== "  /  /")
            {
                MessageBox.Show("Ban can nhap ngay bat dau");
                return;
            }
            if(mskthongtinngaykt.Text== "  /  /")
            {
                MessageBox.Show("Ban can nhap ngay ket thuc");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu không", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                string sql;
                sql = "update tblsukien set tensukien=N'" + txtthongtintensukien.Text + "'," +
                    " ngaybatdau='" + Class.functions.convertdatetime(mskthongtinngaybd.Text) +
                    "',ngayketthuc='" + Class.functions.convertdatetime(mskthongtinngaykt.Text) +
                    "',diadiemtochuc=N'" + txtthongtindiachi.Text + "'" +
                    " where masukien='" + txtthongtinmasukien.Text + " '";
                Class.functions.runsql(sql);
                load_datagridview();
                reset();
            }
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtthongtinmasukien.Text == "")
            {
                MessageBox.Show("Ban can dien ma su kien");
                return;
            }
            if (txtthongtintensukien.Text == "")
            {
                MessageBox.Show("Ban can dien ten su kien");
                return;
            }
            if (txtthongtindiachi.Text == "")
            {
                MessageBox.Show("Ban can dien dia chi su kien");
                return;
            }
            if (mskthongtinngaybd.Text == "  /  /")
            {
                MessageBox.Show("Ban can nhap ngay bat dau");
                return;
            }
            if (mskthongtinngaykt.Text == "  /  /")
            {
                MessageBox.Show("Ban can nhap ngay ket thuc");
                return;
            }
            
            sql = "select masukien from tblsukien where masukien='" + txtthongtinmasukien.Text + "'";
            if (Class.functions.checkey(sql) == true)
            {
                MessageBox.Show("Đã có mã hóa đơn trong cơ sở dữ liệu!");
                txtthongtinmasukien.Text = "";
                txtthongtinmasukien.Focus();
                return;
            }
            if(MessageBox.Show("Ban co muon them du lieu vao bang?","Thong bao",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "insert into tblsukien(masukien,tensukien,ngaybatdau,ngayketthuc,diadiemtochuc)" +
                    " values ('"+txtthongtinmasukien.Text+"" +
                    " ',N'"+txtthongtintensukien.Text+"" +
                    " ','"+Class.functions.convertdatetime(mskthongtinngaybd.Text)+
                    " ','"+Class.functions.convertdatetime(mskthongtinngaykt.Text)+
                    " ',N'"+txtthongtindiachi.Text+"')";
                Class.functions.runsql(sql);
                load_datagridview();
            }
            reset();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = false;
        }
    }
}
