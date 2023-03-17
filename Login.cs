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

namespace ShopVape_Cleanup_Framwork_6_
{
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=" + @"MSI\HNHANTO" + ";Initial Catalog="
                        + "VapeShop" + ";Persist Security Info=True;" +
                        "User ID=" + "sa" + ";Password=" + "12345");
        private string role;
        private int EmpId;
        private string status;
        private bool status1;

        public Login()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "pass456";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string selectquery = "SELECT * FROM Employees WHERE EmployeeUsername =@user" +
                " and EmployeePassword=@pass";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            //MessageBox.Show("role: " + role);
            if(txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Missing Username/Password");
            }
            else
            {
                if (reader1.Read())
                {
                    role = reader1.GetValue(4).ToString();
                    status = reader1.GetValue(5).ToString();
                    EmpId = reader1.GetInt32(0);
                    //status1 = reader1.GetBoolean(5);
                    //MessageBox.Show("role: " + role);
                    //MessageBox.Show("ID: " + EmpId);
                    //MessageBox.Show("Status1: " + status1);
                    reader1.Close();
                    if (status == "True")
                    {
                        MainMenu menu = new MainMenu(role, EmpId, status);
                        this.Hide();
                        //this.Close();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deactived Account");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Lại Đi");
                }
            }          
            con.Close();
        }
    }
}
