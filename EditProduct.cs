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

namespace ShopVape_Cleanup_Framwork_6_
{
    public partial class EditProduct : Form
    {
        private int id;
        private DataGridView _dgv;
        private SqlConnection con = new SqlConnection(@"Data Source=" + @"MSI\HNHANTO" + ";Initial Catalog="
                        + "VapeShop" + ";Persist Security Info=True;" +
                        "User ID=" + "sa" + ";Password=" + "12345");
        public EditProduct(int id, DataGridView dgv)
        {
            InitializeComponent();
            this.id = id;
            _dgv= dgv;
            PopulateBoxes();
            txtNewPrice.Text = txtOldPrice.Text;
            txtAddAmount.Text = "0";
        }
        //Display data for gridView. Use for updating dgv in real-time
        public void displayData(DataGridView dgv, string cmd)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            con.Close();
        }

        //Get original product's data
        private void PopulateBoxes()
        {
            SqlCommand cmd = new SqlCommand("Select * from Items where ItemID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtName.Text = rd.GetValue(1).ToString();
                txtOldPrice.Text = rd.GetValue(2).ToString();
                txtOriginalAmount.Text = rd.GetValue(3).ToString();
            }
            con.Close();
        }

        //Button to confirm product's changes
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string message = "Cập nhật sản phẩm";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            
            if (txtNewPrice.Text != string.Empty && txtAddAmount.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Items set Price=@price, " +
                        "Quantity=@quan where ItemID=@id", con);
                    con.Open();
                    int tmp = Int32.Parse(txtOriginalAmount.Text) + Int32.Parse(txtAddAmount.Text);
                    cmd.Parameters.AddWithValue("@price", txtNewPrice.Text);
                    cmd.Parameters.AddWithValue("@quan", tmp);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayData(_dgv, "select * from Items");
                    Refresh();
                    //this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                // Do something  
                MessageBox.Show("Chưa điền đầy đủ các thông tin");
                return;
            }
        }

        //limit input
        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == 22) e.Handled = true;
        }

        private void txtAddAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == 22) e.Handled = true;
        }

        //Close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            //MainMenu main = new MainMenu();
            
            this.Close();
        }
    }
}
