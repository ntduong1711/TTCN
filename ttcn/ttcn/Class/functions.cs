using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ttcn.Class
{
    internal class functions
    {
        public static SqlConnection conn;
        public static string connstring;

        public static void connect()
        {
            connstring = "Data Source=DESKTOP-VUN3CO5;Initial Catalog=QLhopxuong05;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            //MessageBox.Show("Ket noi thanh cong");
        }
        public static DataTable getdatatotable(string sql)
        {
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = new SqlCommand();
            data.SelectCommand.Connection = Class.functions.conn;
            data.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }
        public static bool checkey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Class.functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static void runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }

        public static bool isdate(string ngaysinh)
        {
            string[] parts = ngaysinh.Split('/');
            if (Convert.ToInt32(parts[0]) >= 1 && Convert.ToInt32(parts[0]) <= 31
                && Convert.ToInt32(parts[1]) <= 12 && Convert.ToInt32(parts[2]) >= 1900)
            {
                return true;
            }
            else
                return false;

        }
        public static string convertdatetime(string ngaysinh)
        {
            string[] parts = ngaysinh.Split('/');
            string ngaysinh_new = string.Format("{0}/{1}/{2}", parts[2], parts[1], parts[0]);
            return ngaysinh_new;
        }
        public static void fillCombo(string sql,ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;

            cbo.ValueMember = ma;    
            cbo.DisplayMember = ten;   
        }
        public static string getfieldvalue(string sql)
        {
            string ma = "";
            SqlCommand cmd=new SqlCommand(sql,Class.functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

      

        public static string removeMaskSDT(string sdt)
        {
            string digits = new string(sdt.Where(char.IsDigit).ToArray());
            return digits;
        }
    }
}
