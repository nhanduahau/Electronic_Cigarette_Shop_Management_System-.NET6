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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopVape_Cleanup_Framwork_6_
{
    public partial class MainMenu : Form
    {
        private string status;
        private string role;
        private int id;
        private int EmpId;
        private SqlConnection con = new SqlConnection(@"Data Source=" + @"MSI\HNHANTO" + ";Initial Catalog="
                        + "VapeShop" + ";Persist Security Info=True;" +
                        "User ID=" + "sa" + ";Password=" + "12345");
        public MainMenu(string role, int Id, string s)
        {
            InitializeComponent();
            this.role = role;
            this.EmpId= Id;
            this.status = s;
            //MessageBox.Show("ID: " + EmpId);
            //Tab2
            displayData(dgvDisplayStorage, "select * from Items");
            displayData(dgvDisplayCustomers, "Select * from Customers");
            displayData(dgvDisplayEmployees, "Select * from Employees");
            displayData(dgvRevenue, "Select * from Invoices");
            functionsVisibility(this.role);
        }

        private void ClearData()
        {
            id = 0;
        }

        private void ClearData1()
        {
            id = 0;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtSearchByName.Text = string.Empty;
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

        //Call the search functions
        private void MainMenu_Load(object sender, EventArgs e)
        {
            autoSearchCustomer();
            AutoSearchProduct();
        }

        //Set user ability to access functions based on login role
        private void functionsVisibility(string role)
        {
            //btnCheck.Enabled = false;
            btnCheck.Visible = false;
            btnRemoveCustomer.Visible = false;
            if (role == "True")
            {
                btnEdit.Visible = false;
                btnAddNew.Visible = false;
                btnCreateAccount.Visible = false;
                btnRemoveEmp.Visible = false;
                //tcMain.TabPages[3].Visible = false;
                tcMain.TabPages.Remove(tpManageEmployees);
            }
        }
        //Reset dgv & local variable(s) when switch tab
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearData();
            displayData(dgvDisplayStorage, "select * from Items");
            displayData(dgvDisplayCustomers, "Select * from Customers");
            displayData(dgvDisplayEmployees, "Select * from Employees");
        }
        
        //Yes/No Confirmation msgBox
        private DialogResult confirmationMssBox(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        //tbSearch Event
        private void tbSearch_TextChanged(object sender, EventArgs e, string query, string value, DataGridView dgv)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@value", value);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            con.Close();
        }
        //Limit input to letters only
        private void tbLetterOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        //Limit input to number only
        private void tbNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //---------------------Tab kho hang-----------------------

        //get itemID
        //need fix: when select empty row throw exception - done
        private void dgvDisplayStorage_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvDisplayStorage.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                //MessageBox.Show("Empty row");
            }
        }
        //Double click: empty->Create new/ not empty->Edit
        private void dgvDisplayStorage_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                EditProduct editProduct;
                if (role == "False")
                {
                    id = Convert.ToInt32(dgvDisplayStorage.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var form = Application.OpenForms["EditProduct"];
                    if(form == null)
                    {
                        //EditProduct editProduct = new EditProduct(id, dgvDisplayStorage);
                        editProduct = new EditProduct(id, dgvDisplayStorage);
                        editProduct.Show();
                    }
                    else
                    {
                        form.Close();
                        //EditProduct editProduct = new EditProduct(id, dgvDisplayStorage);
                        editProduct = new EditProduct(id, dgvDisplayStorage);
                        editProduct.Show();
                    }                   
                }
            }
            catch
            {
                if(role == "False")
                {
                    var form = Application.OpenForms["AddNewProduct"];
                    if (form == null)
                    {
                        AddNewProduct addNewProduct = new AddNewProduct();
                        addNewProduct.Show();
                    }
                    else
                    {
                        form.Close();
                        AddNewProduct addNewProduct = new AddNewProduct();
                        addNewProduct.Show();
                    }
                }
            }

        }

        //search item by name
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            tbSearch_TextChanged(sender, e, "SELECT * FROM Items WHERE ItemName LIKE @value", "%" + txtSearchByName.Text + "%", dgvDisplayStorage);
        }



        //open edit product form
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                MessageBox.Show("Xin chọn sp cần được cập nhật", "Chú ý");
            }
            else
            {
                EditProduct edit = new EditProduct(id, dgvDisplayStorage);
                edit.Show();
            }
        }

        //Open create new product form
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewProduct addNew = new AddNewProduct();
            addNew.Show();
        }

        //-------------------------Tab Khach hang-----------------------

        //search customer by phone
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbSearch_TextChanged(sender, e, "select * from Customers Where PhoneNumber like @value", "%" + txtSearchCustomerByPhone.Text + "%", dgvDisplayCustomers);
        }

        // Điều Chỉnh Thông tin khách hàng
        private void dgvDisplayCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                EditCustomer editCustomer;
                if (role == "False")
                {
                    id = Convert.ToInt32(dgvDisplayCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var form = Application.OpenForms["EditCustomer"];
                    if (form == null)
                    {
                        editCustomer = new EditCustomer(id, dgvDisplayCustomers);
                        editCustomer.Show();
                    }
                    else
                    {
                        form.Close();
                        editCustomer = new EditCustomer(id, dgvDisplayCustomers);
                        editCustomer.Show();
                    }
                }
            }
            catch { }
        }

        //get customerID
        private void dgvDisplayCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvDisplayCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
                //txtCustomerPhone.Text = dgvDisplayCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                //txtCustomerName.Text = dgvDisplayCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
            catch
            {
                //MessageBox.Show("Empty row");
            }           
        }
        //Check duplicated customerPhone
        private bool isDuplicatedCPhone()
        {
            con.Open();
            bool flag = false;
            SqlCommand cmd = new SqlCommand("Select PhoneNumber From Customers Where PhoneNumber = @phone", con);
            cmd.Parameters.AddWithValue("@phone", txtCustomerPhone.Text);
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

        //Add new customer + check trùng SĐT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            
            if (txtCustomerPhone.Text == string.Empty || txtCustomerName.Text == string.Empty)
            {
                MessageBox.Show("Điền đủ các ô thông tin để thêm khách hàng mới");
            }
            else
            {
                if (isDuplicatedCPhone())
                {
                    MessageBox.Show("Trùng SDT");
                }
                else
                {
                    var result = confirmationMssBox("Thêm Khách Hàng mới", "Xác nhận");
                    if (result == DialogResult.Yes)
                    {
                        string phone = txtCustomerPhone.Text;
                        string name = txtCustomerName.Text;
                        string querry = "INSERT INTO Customers(PhoneNumber, CustomerName)" +
                            "VALUES(@phone,@name)";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearData1();
                        displayData(dgvDisplayCustomers, "Select * from Customers");
                    }
                    else
                    {
                        return;
                    }
                }               
            }
        }

        //remove customer
        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                MessageBox.Show("Chọn một danh mục khách hàng để xóa");
            }
            else
            {
                var result = confirmationMssBox("Xóa thông tin khách hàng", "Xác nhận");
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Customers where CustomerID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted successfully");
                    ClearData1();
                    displayData(dgvDisplayCustomers, "Select * from Customers");
                }
                else
                {
                    return;
                }
            }
        }

        //Edit customer
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                MessageBox.Show("Chọn một danh mục khách hàng để chỉnh sửa");
            }
            else
            {
                var form = Application.OpenForms["EditCustomer"];
                EditCustomer editCustomer;
                if (form == null)
                {                    
                    editCustomer = new EditCustomer(id, dgvDisplayCustomers);
                    editCustomer.Show();
                }
                else
                {
                    form.Close();
                    editCustomer = new EditCustomer(id, dgvDisplayCustomers);
                    editCustomer.Show();
                }
            }
        }

        //-------------------Tab quan ly account-------------------
        //Clear Emp textboxes
        private void ClearEmpTextBoxes()
        {
            txtEmpName.Text = string.Empty;
            txtEmpUsername.Text = string.Empty;
            txtEmpPassword.Text = string.Empty;
            id = 0;
        }

        //get EmpId
        private void dgvDisplayEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvDisplayEmployees.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }
            catch
            {
                MessageBox.Show("Empty row");
            }
        }
        //Double click activate/deactivate selected account
        private void dgvDisplayEmployees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgvDisplayEmployees.Rows[e.RowIndex].Cells[0].Value.ToString());

            //get accountStatus and employeeID from selected account
            bool status = false;
            int empID=-1;
            string selectquery = "SELECT * FROM Employees WHERE EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            if(dr.Read())
            {
                status = dr.GetBoolean(5);
                empID = dr.GetInt32(0);
                dr.Close();
            }
            con.Close();

            //Activate/deactivate account
            try
            {
                int tmp;
                id = Convert.ToInt32(dgvDisplayEmployees.Rows[e.RowIndex].Cells[0].Value.ToString());
                if(id != 0 && empID != EmpId)
                {                   
                    if(status)
                    {
                        tmp = 0;
                        var result = confirmationMssBox("Khóa Tài Khoản", "Xác nhận");
                        if(result == DialogResult.Yes)
                        {
                            con.Open();
                            changeAccountStatus(id, tmp);
                            con.Close();
                            displayData(dgvDisplayEmployees, "Select * from Employees");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if(!status)
                    {
                        tmp = 1;
                        var result = confirmationMssBox("Kích Hoạt Tài Khoản", "Xác nhận");
                        if (result == DialogResult.Yes)
                        {
                            con.Open();
                            changeAccountStatus(id, tmp);
                            con.Close();
                            displayData(dgvDisplayEmployees, "Select * from Employees");
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Account in use");
                }
            }
            catch{  }
            }

        //Change account account status
        private void changeAccountStatus(int id, int tmp)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Employees " +
                                "SET AccountStatus=@s WHERE EmployeeID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@s", tmp);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thành Công");
            ClearEmpTextBoxes();           
        }

        //Search Emp
        private void txtSearchEmpByName_TextChanged(object sender, EventArgs e)
        {
            tbSearch_TextChanged(sender, e, "select * from Employees Where EmployeeName like @value", "%" + txtSearchEmpByName.Text + "%", dgvDisplayEmployees);
        }

        //Remove Emp - New: active/deactive account button
        private void txtRemoveEmp_Click(object sender, EventArgs e)
        {
            //New activae/deactivae Function
            bool status = false;
            int empID = -1;
            string selectquery = "SELECT * FROM Employees WHERE EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                status = dr.GetBoolean(5);
                empID = dr.GetInt32(0);
                dr.Close();
            }
            dr.Close();
            con.Close();

            try
            {
                int tmp;
                if (id != 0 && empID != EmpId)
                {
                    if (status)
                    {
                        tmp = 0;
                        var result = confirmationMssBox("Khóa Tài Khoản", "Xác nhận");
                        if (result == DialogResult.Yes)
                        {
                            con.Open(); changeAccountStatus(id, tmp); con.Close();
                            displayData(dgvDisplayEmployees, "Select * from Employees");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (!status)
                    {
                        tmp = 1;
                        var result = confirmationMssBox("Kích Hoạt Tài Khoản", "Xác nhận");
                        if (result == DialogResult.Yes)
                        {
                            con.Open(); changeAccountStatus(id, tmp); con.Close();
                            displayData(dgvDisplayEmployees, "Select * from Employees");
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Account in use");
                }
            }
            catch { }
        }

        //Tao account moi
        private void button1_Click_1(object sender, EventArgs e)
        {
            int role=-1;
            if (rbAdmin.Checked) role = 0;
            if (rbCashier.Checked) role = 1;
            if(txtEmpName.Text == string.Empty || txtEmpUsername.Text == string.Empty || txtEmpPassword.Text == string.Empty || role == -1)
            {
                MessageBox.Show("Điền đủ các thông tin \n" +
                    "mới có thể thêm tài khoản mới");
            }
            else
            {

                string name = txtEmpName.Text;
                string userName = txtEmpUsername.Text;
                string pass = txtEmpPassword.Text;
                string querry = "INSERT INTO Employees(EmployeeName,EmployeeUsername,EmployeePassword,Role)" +
                    "VALUES(@name,@user,@pass,@role,@status)";
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue ("@name", name);
                cmd.Parameters.AddWithValue("@user", userName);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearEmpTextBoxes();
                displayData(dgvDisplayEmployees, "Select * from Employees");
            }
        }

        private void btnStorageF5_Click(object sender, EventArgs e)
        {
            displayData(dgvDisplayStorage, "select * from Items");
        }    

        //---------------tab revenue-------------------
        //Search total revenue between dates
        private void btnSearchRenevueByDate_Click(object sender, EventArgs e)
        {
            string start = dtpStart.Value.ToString("yyyy-MM-dd");
            string end = dtpEnd.Value.ToString("yyyy-MM-dd");

            //Display all
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Invoices Where InvoiceDate" +
                 " between @start and @end", con);
            adapter.SelectCommand.Parameters.AddWithValue("@start", start);
            adapter.SelectCommand.Parameters.AddWithValue("@end", end);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvRevenue.DataSource = dataTable;

            //Display revenue from startDate to endDate
            SqlCommand cmd = new SqlCommand("select SUM(TotalAmount) from Invoices Where InvoiceDate" +
                " between @start and @end", con);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtRevenue.Text = rd[0].ToString();
            }
            else
            {
                MessageBox.Show("Sumthing aint right");
            }
            rd.Close();
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            displayData(dgvRevenue, "Select * from Invoices");
            txtRevenue.Text = string.Empty;
        }
        //-----------------------Tinh tien------------------------------
        //Search + Auto suggest function
        private void autoSearch(string query, AutoCompleteStringCollection collection)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                collection.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        //Search + Auto suggest product name in Tinh Tien
        private void AutoSearchProduct()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            autoSearch("Select ItemName from Items", collection);
            txtSearchProduct.AutoCompleteCustomSource = collection;
        }

        //Search + auto suggest for customer in Tinh tien
        private void autoSearchCustomer()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            autoSearch("Select PhoneNumber from Customers", collection);
            txtTp1CustomerPhone.AutoCompleteCustomSource = collection;
        }


        //Auto fill the price section when ProductName is choosen
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //AutoSearchProduct();
            if(txtSearchProduct.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select Price from Items where ItemName=@name", con);
                //SqlDataAdapter sqlData = new SqlDataAdapter("select Price from Items where ItemName=@name", con);
                cmd.Parameters.AddWithValue("@name", txtSearchProduct.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txtSearchPrice.Text = dr[0].ToString();
                }
                dr.Close();
                con.Close();
            }
        }

        //Auto fill customerName when phoneNumber is choosen
        private void txtTp1CustomerPhone_TextChanged(object sender, EventArgs e)
        {
            //autoSearchCustomer();
            if (txtTp1CustomerPhone.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select CustomerName from Customers where PhoneNumber=@phone", con);
                //SqlDataAdapter sqlData = new SqlDataAdapter("select Price from Items where ItemName=@name", con);
                cmd.Parameters.AddWithValue("@phone", txtTp1CustomerPhone.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtTp1CustomerName.Text = dr[0].ToString();
                    dr.Close();
                }
                con.Close();
            }
        }

        //Button add items to basket
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if(txtSearchProduct.Text == string.Empty || txtSearchPrice.Text == string.Empty || txtSearchAmount.Text == string.Empty)
            {
                MessageBox.Show("Điền Đầy Đủ Thông Tin");
            }
            else
            {
                int count = dgvBasket.RowCount;
                int storedAmount=0, requestedAmount = Convert.ToInt32(txtSearchAmount.Text);
                float totalMoney;
                string name= txtSearchProduct.Text;
                bool flag = true;
                if(count == 1)
                {
                    totalMoney = requestedAmount * Convert.ToInt32(txtSearchPrice.Text);
                    string[] row = new string[] { txtSearchProduct.Text, txtSearchPrice.Text, txtSearchAmount.Text, totalMoney.ToString() };
                    dgvBasket.Rows.Add(row);
                }
                else if (checkDuplicatedItem(count,name))
                {
                    totalMoney = requestedAmount * Convert.ToInt32(txtSearchPrice.Text);
                    string[] row = new string[] { txtSearchProduct.Text, txtSearchPrice.Text, txtSearchAmount.Text, totalMoney.ToString() };
                    dgvBasket.Rows.Add(row);
                }
            }     
        }
        //Check for duplicated item in Basket
        private bool checkDuplicatedItem(int count, string name)
        {
            bool flag = true;
            for(int i = 0; i < count - 1; i++)
            {
                if(name == dgvBasket.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng sản phẩm");
                    return flag = false;
                }
            }
            return flag;
        }

        
        //Button to check out add records to tbl Invoice & InvoiceItems
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtTp1CustomerName.Text == string.Empty || txtTp1CustomerPhone.Text == string.Empty)
            {
                MessageBox.Show("Thiếu thông tin khách hàng");
            }
            else
            {
                int i = dgvBasket.Columns.Count;
                double totalMoney = 0;

                con.Open();
                string querry = "Insert Into Invoices Values(@cId,@empId,@date,@money)";
                string sDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@cId", getCustomerID());
                cmd.Parameters.AddWithValue("@empId", EmpId);
                cmd.Parameters.AddWithValue("@date", sDate);
                for (i = 0; i < dgvBasket.Rows.Count; i++)
                {
                    totalMoney += Convert.ToDouble(dgvBasket.Rows[i].Cells[3].Value);
                }
                cmd.Parameters.AddWithValue("@money", totalMoney);
                //add to Invoice here
                cmd.ExecuteNonQuery();

                //Set up for getting InvoiceID
                querry = "select TOP 1 InvoiceID from Invoices Where " +
                    "CustomerID=@cId and EmployeeID=@empId and " +
                    "InvoiceDate=@date and TotalAmount=@money " +
                    "ORDER BY InvoiceID DESC";
                cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@cId", getCustomerID());
                cmd.Parameters.AddWithValue("@empId", EmpId);
                cmd.Parameters.AddWithValue("@date", sDate);
                cmd.Parameters.AddWithValue("@money", totalMoney);

                //get InvoiceID here
                int iId = -1;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    iId = Convert.ToInt32(dr.GetValue(0));
                }
                dr.Close();
                con.Close();

                //Add list from dgv to InvoiceDetail
                if (iId > 0)
                {
                    //con.Open();
                    for (i = 0; i < dgvBasket.Rows.Count - 1; i++)
                    {
                        con.Open();
                        int pID = getProductID(i);
                        int itemTotal = getNumberOfItems(i);
                        decimal totalPrice = getOneCategoryPrice(i);
                        con.Close();
                        cmd = new SqlCommand("Insert into InvoiceItems Values(@ivID,@iId,@quantity,@price)", con);
                        cmd.Parameters.AddWithValue("@ivID", iId);
                        cmd.Parameters.AddWithValue("@iId", pID);
                        cmd.Parameters.AddWithValue("@quantity",  itemTotal);
                        cmd.Parameters.AddWithValue("@price", totalPrice);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        updateNumberOfItems(i, itemTotal);
                        con.Close();
                    }
                    //con.Close();
                }
                MessageBox.Show("Hoàn Tất");
                //con.Close();
            }
            //con.Close();
        }



        //Button to test functions
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CustomerID: " + getCustomerID());
            //MessageBox.Show("ProductID: " + getProductID(1));
            //MessageBox.Show("NumberOfItem: " + getNumberOfItems(0));
            //MessageBox.Show("TotalItemPrice: " + getOneCategoryPrice(0));
            //MessageBox.Show("Rows: " + dgvBasket.Rows.Count);
            //updateNumberOfItems(0, 1);
            string test = dgvBasket.Rows[0].Cells[0].Value.ToString();
            MessageBox.Show("Name: " + test);
            
        }

        //Get CustomerID
        private int getCustomerID()
        {
            int id=-1;
            SqlCommand cmd = new SqlCommand("Select CustomerID from Customers where PhoneNumber=@phone", con);
            cmd.Parameters.AddWithValue("@phone", txtTp1CustomerPhone.Text);
            //con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0].ToString());
                //con.Close();
                dr.Close();
                return id;
            }
            dr.Close();
            //con.Close();
            return id;
        }
        //Get ProductID
        private int getProductID(int i)
        {
            int id=-1;
            SqlCommand cmd = new SqlCommand("Select ItemID from Items where ItemName=@name", con);
            cmd.Parameters.AddWithValue("@name", Convert.ToString(dgvBasket.Rows[i].Cells[0].Value));
            //con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0].ToString());
                //con.Close();
                dr.Close();
                return id;
            }
            dr.Close();
            //con.Close();
            return id;
        }
        //Get number of Items per itemID
        private int getNumberOfItems(int i)
        {
            int count = Convert.ToInt32(dgvBasket.Rows[i].Cells[2].Value);
            return count;
        }
        //Get total price for 1 item category
        private decimal getOneCategoryPrice(int i)
        {
            decimal total = Convert.ToDecimal(dgvBasket.Rows[i].Cells[3].Value);
            return total;
        }


        //Delete from basket
        private void dgvBasket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvBasket.Rows.RemoveAt(dgvBasket.CurrentCell.RowIndex);
            }
            catch
            {
                
            }
        }
        //Update table Items after transaction
        private void updateNumberOfItems(int i, int subtractAmount)
        {
            int originalAmount;
            int id = getProductID(i);
            SqlCommand cmd = new SqlCommand("Select Quantity from Items where ItemID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            //con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                originalAmount = Convert.ToInt32(dr[0]);
                //MessageBox.Show("OriAmount: " + originalAmount);
                dr.Close();
                cmd = new SqlCommand("Update Items Set Quantity = @nb where ItemID=@id", con);
                cmd.Parameters.AddWithValue("@nb", originalAmount - subtractAmount);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            dr.Close();
           // con.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        //Get max amount allowed to add to basket
        private void txtSearchAmount_TextChanged_1(object sender, EventArgs e)
        {
            int storedAmount, requestedAmount;
            if (txtSearchPrice.Text != string.Empty)
            {
                requestedAmount = Int32.Parse(txtSearchAmount.Text);
                SqlCommand cmd = new SqlCommand("Select Quantity From Items Where ItemName=@name", con);
                string name = txtSearchProduct.Text;
                cmd.Parameters.AddWithValue("@name", name);
                con.Close( );
                con.Open();
                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.Read())
                {
                    storedAmount = Convert.ToInt32(sqlData.GetValue(0).ToString());
                    sqlData.Close();
                    if(requestedAmount > storedAmount)
                    {
                        MessageBox.Show("Không đủ hàng trong kho\n" +
                        "Hàng trong kho: " + storedAmount.ToString());
                        txtSearchAmount.Text = storedAmount.ToString();
                    }
                    sqlData.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Sumthing aint right");
                    con.Close();
                }
                con.Close();
            }           
        }
    }
}
