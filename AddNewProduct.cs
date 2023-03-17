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
    public partial class AddNewProduct : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=" + @"MSI\HNHANTO" + ";Initial Catalog="
                        + "VapeShop" + ";Persist Security Info=True;" +
                        "User ID=" + "sa" + ";Password=" + "12345");
        public AddNewProduct()
        {
            InitializeComponent();
        }

        //Create new product
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool flag = true;
            do
            {
                if (txtName.Text == string.Empty || txtPrice.Text == string.Empty || txtAmount.Text == string.Empty)
                {
                    flag = false;
                    MessageBox.Show("Please fill in all details");
                }
                else
                {
                    if (isDuplicated())
                    {
                        MessageBox.Show("Trùng Tên SP");
                        flag=false;
                    }
                    else
                    {
                        string message = "Nhập sản phẩm mới";
                        string title = "Xác nhận";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            string name = txtName.Text;
                            int price = Int32.Parse(txtPrice.Text);
                            int amount = Int32.Parse(txtAmount.Text);
                            SqlCommand cmd = new SqlCommand("insert into Items(ItemName,Price,Quantity)" +
                                "values(@name,@price,@amount)", con);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            flag = false;
                            con.Close();
                        }
                        else
                        {
                            flag = false;
                        }
                    }                   
                }
            } while (flag);
        }

        //Close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            //isDuplicated();
            this.Close();
        }

        //Limit price input
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //if (e.KeyChar == 22) e.Handled = true;
        }

        //Limit amount input
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //if (e.KeyChar == 22) e.Handled = true;
        }

        //Check for duplicated Name
        private bool isDuplicated()
        {
            con.Open();
            bool flag = false;
            SqlCommand cmd = new SqlCommand("Select ItemName From Items Where ItemName = @name", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                flag = true;
                dr.Close();
                con.Close();
                return flag;
            }
            dr.Close();
            con.Close();
            return flag;
        }
    }
}
