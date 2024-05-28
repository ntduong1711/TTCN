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
    public partial class xeplop : Form
    {
        public xeplop()
        {
            InitializeComponent();
        }
        DataTable tbhocvien;
        private void xeplop_Load(object sender, EventArgs e)
        {
            Class.functions.fillCombo("select tbllophoc.malophoc as ma,tenlophoc, count(mahocvien) as slhocvien " +
                   "from tbllophoc left join tblthamgia on tbllophoc.malophoc=tblthamgia.malophoc"+
                   " group by tenlophoc,tbllophoc.malophoc,sisomax " +
                   " having count(mahocvien)<sisomax", cbolophoc, "ma", "tenlophoc");
            cbolophoc.SelectedIndex = -1;

            listhocvien.SelectionMode = SelectionMode.One;

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (mskngaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Ban chon ngay bat dau ki hoc");
                return;
            }
            if (mskngayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Ban chon ngay ket thuc ki hoc");
                return;
            }

            string sql;
            sql = "select tblhocvien.mahocvien as ma,tenhocvien from tblhocvien " +
                " left join " +
                " (select mahocvien from tblthamgia inner join tbllophoc " +
                " on tblthamgia.malophoc=tbllophoc.malophoc" +
                " where ngaybatdau>='"+Class.functions.convertdatetime(mskngaybatdau.Text)+"' and " +
                " ngayketthuc<='"+Class.functions.convertdatetime(mskngayketthuc.Text)+"') as tbllop_dk" +
                " on tblhocvien.mahocvien=tbllop_dk.mahocvien" +
                " where tbllop_dk.mahocvien is null";
            tbhocvien = Class.functions.getdatatotable(sql);
            foreach(DataRow row in tbhocvien.Rows)
            {
                string maten = $"{row["ma"]} - {row["tenhocvien"]}";
                listhocvien.Items.Add(maten);
            }
        }

        private void btnhienthilop_Click(object sender, EventArgs e)
        {

            if(cbolophoc.Text=="")
            {
                MessageBox.Show("Chon lop hoc");
                return;
            }
            listthanhvienlop.Items.Clear();
            


            string sql;
            sql = "select tblhocvien.mahocvien as ma,tenhocvien,capdo,loaigiong from tblhocvien " +
                " inner join tblthamgia on tblhocvien.mahocvien=tblthamgia.mahocvien" +
                " inner join tbllophoc on tblthamgia.malophoc=tbllophoc.malophoc" +
                " where tbllophoc.malophoc='"+cbolophoc.SelectedValue.ToString()+"'";
            tbhocvien = Class.functions.getdatatotable(sql);
            foreach (DataRow row in tbhocvien.Rows)
            {
                string hocvien = $"{row["ma"]} - {row["tenhocvien"]}";
                listthanhvienlop.Items.Add(hocvien);
            }
            
        }

        private void listhocvien_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon them  " + listhocvien.SelectedItem+ "  vao lop",
                "thong bao",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               string hv=listhocvien.SelectedItem.ToString();
                listhocvien.Items.Remove(hv);
                listthanhvienlop.Items.Add(hv);
            }
        }

        private void listthanhvienlop_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban muon xoa "+ listthanhvienlop.SelectedItem+ " khoi lop",
                "thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string thanhvienlop = listthanhvienlop.SelectedItem.ToString();
                listthanhvienlop.Items.Remove(thanhvienlop);
                listhocvien.Items.Add(thanhvienlop);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblthamgia";
            tbhocvien=Class.functions.getdatatotable(sql);
            foreach(var item in listthanhvienlop.Items)
            {
                string[] parts = item.ToString().Split(new string[] { " - " }, 
                    StringSplitOptions.None);
                string mahocvien = parts[0];
                string malophoc = cbolophoc.SelectedValue.ToString();

                foreach (DataRow row in tbhocvien.Rows)
                {
                    string hv = row["mahocvien"].ToString();
                    string lh = row["malophoc"].ToString();
                    if((mahocvien!=hv && malophoc==lh) ||(mahocvien==hv && malophoc!=lh)
                        ||(mahocvien!=hv && malophoc != lh))
                    {
                        string sql1;
                        sql1 = "insert into tblthamgia(mahocvien,malophoc) values" +
                            " ('" + mahocvien + "','" + malophoc + "')";
                        Class.functions.runsql(sql1);
                        break;
                    }
                }
               
            }
        }
    }
}
