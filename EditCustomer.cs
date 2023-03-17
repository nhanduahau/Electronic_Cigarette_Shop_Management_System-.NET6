using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopVape_Cleanup_Framwork_6_
{
    public partial class EditCustomer : Form
    {
        private int id;
        DataGridView _dgv;
        private SqlConnection con = new SqlConnection(@"Data Source=" + @"MSI\HNHANTO" + ";Initial Catalog="
                        + "VapeShop" + ";Persist Security Info=True;" +
                        "User ID=" + "sa" + ";Password=" + "12345");
        public EditCustomer(int id, DataGridView dgv)
        {
            InitializeComponent();
            this.id = id;
            this._dgv = dgv;
            PopulateTB();
        }

        public void displayData(DataGridView dgv, string cmd)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            con.Close();
        }
        //Fill textBoxes
        private void PopulateTB()
        {
            SqlCommand cmd = new SqlCommand("Select * from Customers where CustomerID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                tbOldName.Text = rd.GetValue(2).ToString();
                tbOldPhone.Text = rd.GetValue(1).ToString();
                rd.Close();
                tbName.Text = tbOldName.Text;
                tbPhone.Text = tbOldPhone.Text;
            }
            con.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string message = "Cập nhật thông tin khách hàng";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (tbPhone.Text != "" && tbName.Text != "")
            {
                if (isDuplicatedCPhone())
                {
                    MessageBox.Show("Trùng SĐT");
                }
                else
                {
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("update Customers set " +
                        "PhoneNumber=@phone, CustomerName=@name where " +
                        "CustomerID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                        cmd.Parameters.AddWithValue("@name", tbName.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succeed");
                        con.Close();
                        //ClearData();
                        displayData(_dgv, "Select * from Customers");
                    }
                    else
                    {
                        con.Close();
                        return;
                    }
                }                
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin để sửa thông tin khách hàng");
            }
        }
        //Close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Check duplicatePhone
        private bool isDuplicatedCPhone()
        {
            con.Open();
            bool flag = false;
            SqlCommand cmd = new SqlCommand("Select * From Customers Where PhoneNumber = @phone", con);
            cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int tmpID = Convert.ToInt32(dr.GetValue(0).ToString());
                if(id == tmpID)
                {
                    dr.Close();
                    con.Close();
                    return flag;
                }
                else
                {
                    flag = true;
                    dr.Close();
                    con.Close();
                    return flag;
                }
            }
            dr.Close();
            con.Close();
            return flag;
        }
    }
}
