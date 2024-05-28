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
    public partial class phieuchi : Form
    {
        public phieuchi()
        {
            InitializeComponent();
        }
        DataTable tbphieuchi;
        private void phieuchi_Load(object sender, EventArgs e)
        {
            datagridview_load();
            Class.functions.fillCombo("select masukien,tensukien from tblsukien",cbothongtinsukien,
                "masukien","tensukien");
            cbothongtinsukien.SelectedIndex = -1;
            Class.functions.fillCombo("select manhanvien,tennhanvien from tblnhanvien inner join tblbophan on tblbophan.mabophan=tblnhanvien.mabophan where tenbophan like N'%bộ phận tài chính%'",cbothongtinnguoinhan,
                "manhanvien","tennhanvien");
            cbothongtinnguoinhan.SelectedIndex = -1;
            Class.functions.fillCombo("select manhanvien,tennhanvien from tblnhanvien inner join tblbophan on tblbophan.mabophan=tblnhanvien.mabophan where tenbophan like N'%bộ phận tài chính%'", cbotimkiemnguoinhan,
                "manhanvien", "tennhanvien");
            cbotimkiemnguoinhan.SelectedIndex=-1;

            txttimkiemsophieu.Enabled = false;
            txttimkiemsukien.Enabled = false;
            cbotimkiemtrangthai.Enabled = false;
            cbotimkiemnguoinhan.Enabled = false;

            cbotimkiemtrangthai.Items.Add("Đã duyệt");
            cbotimkiemtrangthai.Items.Add("Chưa duyệt");
        }
        private void datagridview_load()
        {
            string sql;
            sql = "select maphieuchi,tensukien,tblnhanvien.manhanvien,sotien,trangthai from tblphieuchi " +
                "inner join tblsukien on tblphieuchi.masukien=tblsukien.masukien" +
                " inner join tblnhanvien on tblnhanvien.manhanvien=tblphieuchi.manhanvien";
            tbphieuchi=Class.functions.getdatatotable(sql); 
            dataGridViewphieuchi.DataSource = tbphieuchi;
            dataGridViewphieuchi.AllowUserToAddRows = false;
            dataGridViewphieuchi.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridViewphieuchi_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo");
            }
            if (tbphieuchi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng", "Thông báo");
            }
            txtthongtinsophieu.Text = dataGridViewphieuchi.CurrentRow.Cells[0].Value.ToString();
            txtthongtintongtien.Text = dataGridViewphieuchi.CurrentRow.Cells[3].Value.ToString();
            cbothongtinnguoinhan.Text = dataGridViewphieuchi.CurrentRow.Cells[2].Value.ToString();
            cbothongtinsukien.Text = dataGridViewphieuchi.CurrentRow.Cells[1].Value.ToString();
            string trangthai;
            trangthai = dataGridViewphieuchi.CurrentRow.Cells[4].Value.ToString();
            if(trangthai=="Đã duyệt")
            {
                rdodaduyet.Checked = true;
            }
            else
                rdochuaduyet.Checked=false;

        }

        private void chktheosophieu_Click(object sender, EventArgs e)
        {
            if (chktheosophieu.Checked == true)
            {
                txttimkiemsophieu.Enabled = true;
            }
            else
                txttimkiemsophieu.Enabled = false;
        }

        private void chktheonguoinhan_Click(object sender, EventArgs e)
        {
            if (chktheonguoinhan.Checked == true)
            {
                cbotimkiemnguoinhan.Enabled = true;
            }
            else
                cbotimkiemnguoinhan.Enabled = false;
        }

        private void chktheosukien_Click(object sender, EventArgs e)
        {
            if (chktheosukien.Checked == true)
            {
                txttimkiemsukien.Enabled = true;
            }
            else
                txttimkiemsukien.Enabled = false;
        }

        private void chktheotrangthai_Click(object sender, EventArgs e)
        {
            if (chktheotrangthai.Checked == true)
            {
                cbotimkiemtrangthai.Enabled = true;
            }
            else
                cbotimkiemtrangthai.Enabled = false;
        }
        private void reset()
        {
            txtthongtinsophieu.Text = "";
            txtthongtintongtien.Text = "";
            cbothongtinnguoinhan.Text = "";
            cbothongtinsukien.Text = "";
            rdochuaduyet.Checked = false;
            rdodaduyet.Checked = false;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select maphieuchi,tensukien,tblnhanvien.manhanvien,sotien,trangthai from tblphieuchi inner join tblsukien on tblphieuchi.masukien=tblsukien.masukien" +
                " inner join tblnhanvien on tblnhanvien.manhanvien=tblphieuchi.manhanvien where 1=1";
            if(chktheosophieu.Checked== true)
            {
                sql = sql + " and maphieuchi like '%"+txttimkiemsophieu.Text+"%'";
            }
            if(chktheonguoinhan.Checked== true)
            {
                sql = sql + " and tblnhanvien.manhanvien like N'%" + cbotimkiemnguoinhan.SelectedValue.ToString()+"%'";
            }
            if(chktheosukien.Checked==true)
            {
                sql = sql + " and masukien like N'%"+txttimkiemsukien.Text+"%'";
            }
            if(chktheotrangthai.Checked==true)
            {
                sql = sql + "and trangthai like N'%"+cbotimkiemtrangthai.Text+"%'";
            }
            tbphieuchi = Class.functions.getdatatotable(sql);
            if (tbphieuchi.Rows.Count == 0)
            {
                MessageBox.Show("Không có phiếu phù hợp");
            }
            else
                MessageBox.Show("Có " + tbphieuchi.Rows.Count + " bản ghi phù hợp");
            dataGridViewphieuchi.DataSource = tbphieuchi;

        }

        private void btndatlai_Click(object sender, EventArgs e)
        {
            txttimkiemsophieu.Text = "";
            txttimkiemsukien.Text = "";
            cbotimkiemnguoinhan.Text = "";
            cbotimkiemtrangthai.Text = "";

            chktheosophieu.Checked = false;
            chktheosukien.Checked=false;
            chktheotrangthai.Checked=false;
            chktheonguoinhan.Checked=false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled=false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            txtthongtinsophieu.Enabled = true;
            txtthongtinsophieu.Focus();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(txtthongtinsophieu.Text=="")
            {
                MessageBox.Show("Bạn cần điền mã phiếu");
                return;
            }
            if (txtthongtintongtien.Text == "")
            {
                MessageBox.Show("Bạn cần điền tổng tiền ");
                return;
            }
            if(rdochuaduyet.Checked==false && rdodaduyet.Checked==false)
            {
                MessageBox.Show("Bạn cần chọn trạng thái xét duyệt");
                return;
            }
            /*if (cbothongtinnguoinhan.Text == "")
            {
                MessageBox.Show("Bạn cần chọn người nhận");
                return;
            }
            if (cbothongtinsukien.Text == "")
            {
                MessageBox.Show("Bạn cần chọn sự kiện");
                return;
            }*/
            string sql;
            sql = "select maphieuchi from tblphieuchi where maphieuchi='"+txtthongtinsophieu.Text+"'";
            if (Class.functions.checkey(sql)==true)
            {
                MessageBox.Show("Đã có mã hóa đơn trong cơ sở dữ liệu!");
                txtthongtinsophieu.Text = "";
                txtthongtinsophieu.Focus();
                return;
            }
            string trangthai;
            if(rdodaduyet.Checked== true)
            {
                trangthai = "Đã duyệt";
            }
            else
                trangthai= "Chưa duyệt";
            sql = "insert into tblphieuchi (maphieuchi,masukien,manhanvien,sotien,trangthai) values" +
                "('"+txtthongtinsophieu.Text+"','"+cbothongtinsukien.SelectedValue.ToString()+
                "','"+cbothongtinnguoinhan.SelectedValue.ToString()+
                "',"+txtthongtintongtien.Text+",N'"+trangthai+"')";
            Class.functions.runsql(sql);
            datagridview_load();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tbphieuchi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu trong bảng");
                return;
            }
            if (txtthongtinsophieu.Text == "")
            {
                MessageBox.Show("Bạn cần chọn bản ghi cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                string sql;
                sql = "delete tblphieuchi where maphieuchi='"+txtthongtinsophieu.Text+"'";
                Class.functions.RunSqlDel(sql);
                datagridview_load();
                reset();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            if (tbphieuchi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng");
                return;
            }
            if (txtthongtinsophieu.Text == "")
            {
                MessageBox.Show("Bạn cần chọn bản ghi cần sửa");
                return;
            }
            if(txtthongtintongtien.Text=="")
            {
                MessageBox.Show("Bạn cần nhập tổng tiền");
                return;
            }
            if (rdochuaduyet.Checked == false && rdodaduyet.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn trạng thái xét duyệt");
                return;
            }
            string trangthai;
            if (rdodaduyet.Checked == true)
            {
                trangthai = "Đã duyệt";
            }
            else
                trangthai = "Chưa duyệt";

            if (MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu không", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                string sql;
                sql = "update tblphieuchi set manhanvien='"+cbothongtinnguoinhan.SelectedValue.ToString()+
                    "',masukien='"+cbothongtinsukien.SelectedValue.ToString()+" '," +
                    "sotien="+txtthongtintongtien.Text+"," +
                    "trangthai=N'"+trangthai+"' where maphieuchi='"+txtthongtinsophieu.Text+"'";
                Class.functions.runsql(sql);
                datagridview_load();
                reset();
            }
            btnboqua.Enabled = false;
            txtthongtinsophieu.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtthongtinsophieu.Enabled = false;
        }
    }
}
