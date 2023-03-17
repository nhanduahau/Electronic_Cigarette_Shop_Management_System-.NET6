namespace ShopVape_Cleanup_Framwork_6_
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpTransaction = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTp1CustomerName = new System.Windows.Forms.TextBox();
            this.txtTp1CustomerPhone = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.txtSearchAmount = new System.Windows.Forms.TextBox();
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchPrice = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.tpStorage = new System.Windows.Forms.TabPage();
            this.btnStorageF5 = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisplayStorage = new System.Windows.Forms.DataGridView();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerByPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplayCustomers = new System.Windows.Forms.DataGridView();
            this.tpManageEmployees = new System.Windows.Forms.TabPage();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchEmpByName = new System.Windows.Forms.TextBox();
            this.gbCreateAccount = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.rbCashier = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmpUsername = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDisplayEmployees = new System.Windows.Forms.DataGridView();
            this.tpRevenue = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchRevenueByDate = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            this.tpStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStorage)).BeginInit();
            this.tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomers)).BeginInit();
            this.tpManageEmployees.SuspendLayout();
            this.gbCreateAccount.SuspendLayout();
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmployees)).BeginInit();
            this.tpRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpTransaction);
            this.tcMain.Controls.Add(this.tpStorage);
            this.tcMain.Controls.Add(this.tpCustomer);
            this.tcMain.Controls.Add(this.tpManageEmployees);
            this.tcMain.Controls.Add(this.tpRevenue);
            this.tcMain.Location = new System.Drawing.Point(10, 46);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(669, 341);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpTransaction
            // 
            this.tpTransaction.Controls.Add(this.label15);
            this.tpTransaction.Controls.Add(this.label14);
            this.tpTransaction.Controls.Add(this.label13);
            this.tpTransaction.Controls.Add(this.label12);
            this.tpTransaction.Controls.Add(this.label11);
            this.tpTransaction.Controls.Add(this.txtTp1CustomerName);
            this.tpTransaction.Controls.Add(this.txtTp1CustomerPhone);
            this.tpTransaction.Controls.Add(this.btnCheckOut);
            this.tpTransaction.Controls.Add(this.btnAddToBasket);
            this.tpTransaction.Controls.Add(this.txtSearchAmount);
            this.tpTransaction.Controls.Add(this.dgvBasket);
            this.tpTransaction.Controls.Add(this.txtSearchPrice);
            this.tpTransaction.Controls.Add(this.txtSearchProduct);
            this.tpTransaction.Location = new System.Drawing.Point(4, 29);
            this.tpTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.tpTransaction.Name = "tpTransaction";
            this.tpTransaction.Padding = new System.Windows.Forms.Padding(2);
            this.tpTransaction.Size = new System.Drawing.Size(661, 308);
            this.tpTransaction.TabIndex = 3;
            this.tpTransaction.Text = "Tính Tiền";
            this.tpTransaction.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(426, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "SDT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Số Lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Giá Sản Phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tên Sản Phẩm";
            // 
            // txtTp1CustomerName
            // 
            this.txtTp1CustomerName.Location = new System.Drawing.Point(467, 46);
            this.txtTp1CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTp1CustomerName.Name = "txtTp1CustomerName";
            this.txtTp1CustomerName.ReadOnly = true;
            this.txtTp1CustomerName.Size = new System.Drawing.Size(146, 27);
            this.txtTp1CustomerName.TabIndex = 7;
            // 
            // txtTp1CustomerPhone
            // 
            this.txtTp1CustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTp1CustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTp1CustomerPhone.Location = new System.Drawing.Point(466, 14);
            this.txtTp1CustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTp1CustomerPhone.Name = "txtTp1CustomerPhone";
            this.txtTp1CustomerPhone.Size = new System.Drawing.Size(147, 27);
            this.txtTp1CustomerPhone.TabIndex = 6;
            this.txtTp1CustomerPhone.TextChanged += new System.EventHandler(this.txtTp1CustomerPhone_TextChanged);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(467, 82);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(90, 27);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(262, 80);
            this.btnAddToBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(90, 27);
            this.btnAddToBasket.TabIndex = 4;
            this.btnAddToBasket.Text = "Thêm Sp";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // txtSearchAmount
            // 
            this.txtSearchAmount.Location = new System.Drawing.Point(118, 82);
            this.txtSearchAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchAmount.Name = "txtSearchAmount";
            this.txtSearchAmount.ShortcutsEnabled = false;
            this.txtSearchAmount.Size = new System.Drawing.Size(117, 27);
            this.txtSearchAmount.TabIndex = 3;
            this.txtSearchAmount.TextChanged += new System.EventHandler(this.txtSearchAmount_TextChanged_1);
            this.txtSearchAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberOnly_KeyPress);
            // 
            // dgvBasket
            // 
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Amount,
            this.TotalPrice});
            this.dgvBasket.Location = new System.Drawing.Point(5, 126);
            this.dgvBasket.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.RowHeadersWidth = 62;
            this.dgvBasket.RowTemplate.Height = 33;
            this.dgvBasket.Size = new System.Drawing.Size(654, 180);
            this.dgvBasket.TabIndex = 2;
            this.dgvBasket.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBasket_RowHeaderMouseDoubleClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá Tiền";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Thành Tiền";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 150;
            // 
            // txtSearchPrice
            // 
            this.txtSearchPrice.Location = new System.Drawing.Point(118, 46);
            this.txtSearchPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPrice.Name = "txtSearchPrice";
            this.txtSearchPrice.ReadOnly = true;
            this.txtSearchPrice.Size = new System.Drawing.Size(234, 27);
            this.txtSearchPrice.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchProduct.Location = new System.Drawing.Point(118, 14);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(234, 27);
            this.txtSearchProduct.TabIndex = 0;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // tpStorage
            // 
            this.tpStorage.Controls.Add(this.btnStorageF5);
            this.tpStorage.Controls.Add(this.btnAddNew);
            this.tpStorage.Controls.Add(this.btnEdit);
            this.tpStorage.Controls.Add(this.txtSearchByName);
            this.tpStorage.Controls.Add(this.label1);
            this.tpStorage.Controls.Add(this.dgvDisplayStorage);
            this.tpStorage.Location = new System.Drawing.Point(4, 29);
            this.tpStorage.Margin = new System.Windows.Forms.Padding(2);
            this.tpStorage.Name = "tpStorage";
            this.tpStorage.Padding = new System.Windows.Forms.Padding(2);
            this.tpStorage.Size = new System.Drawing.Size(661, 308);
            this.tpStorage.TabIndex = 1;
            this.tpStorage.Text = "Kho Hàng";
            this.tpStorage.UseVisualStyleBackColor = true;
            // 
            // btnStorageF5
            // 
            this.btnStorageF5.Location = new System.Drawing.Point(461, 6);
            this.btnStorageF5.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorageF5.Name = "btnStorageF5";
            this.btnStorageF5.Size = new System.Drawing.Size(90, 27);
            this.btnStorageF5.TabIndex = 5;
            this.btnStorageF5.Text = "Refresh";
            this.btnStorageF5.UseVisualStyleBackColor = true;
            this.btnStorageF5.Click += new System.EventHandler(this.btnStorageF5_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(157, 272);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 27);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Thêm Sp";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(5, 272);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Điều Chỉnh Sp";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(122, 7);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(334, 27);
            this.txtSearchByName.TabIndex = 2;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Khách Hàng";
            // 
            // dgvDisplayStorage
            // 
            this.dgvDisplayStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplayStorage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStorage.Location = new System.Drawing.Point(5, 37);
            this.dgvDisplayStorage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisplayStorage.Name = "dgvDisplayStorage";
            this.dgvDisplayStorage.RowHeadersWidth = 62;
            this.dgvDisplayStorage.RowTemplate.Height = 33;
            this.dgvDisplayStorage.Size = new System.Drawing.Size(652, 212);
            this.dgvDisplayStorage.TabIndex = 0;
            this.dgvDisplayStorage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayStorage_RowHeaderMouseClick);
            this.dgvDisplayStorage.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayStorage_RowHeaderMouseDoubleClick);
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.btnRemoveCustomer);
            this.tpCustomer.Controls.Add(this.btnEditCustomer);
            this.tpCustomer.Controls.Add(this.btnAdd);
            this.tpCustomer.Controls.Add(this.txtCustomerName);
            this.tpCustomer.Controls.Add(this.txtCustomerPhone);
            this.tpCustomer.Controls.Add(this.txtSearchCustomerByPhone);
            this.tpCustomer.Controls.Add(this.label4);
            this.tpCustomer.Controls.Add(this.label3);
            this.tpCustomer.Controls.Add(this.label2);
            this.tpCustomer.Controls.Add(this.dgvDisplayCustomers);
            this.tpCustomer.Location = new System.Drawing.Point(4, 29);
            this.tpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Size = new System.Drawing.Size(661, 308);
            this.tpCustomer.TabIndex = 2;
            this.tpCustomer.Text = "Khách Hàng";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(501, 246);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(90, 62);
            this.btnRemoveCustomer.TabIndex = 3;
            this.btnRemoveCustomer.Text = "Xóa";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(501, 86);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(90, 25);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Chỉnh sửa";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 51);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm khách hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(128, 86);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ShortcutsEnabled = false;
            this.txtCustomerName.Size = new System.Drawing.Size(342, 27);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLetterOnly_KeyPress);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(128, 51);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ShortcutsEnabled = false;
            this.txtCustomerPhone.Size = new System.Drawing.Size(342, 27);
            this.txtCustomerPhone.TabIndex = 2;
            this.txtCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberOnly_KeyPress);
            // 
            // txtSearchCustomerByPhone
            // 
            this.txtSearchCustomerByPhone.Location = new System.Drawing.Point(128, 8);
            this.txtSearchCustomerByPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCustomerByPhone.Name = "txtSearchCustomerByPhone";
            this.txtSearchCustomerByPhone.Size = new System.Drawing.Size(342, 27);
            this.txtSearchCustomerByPhone.TabIndex = 2;
            this.txtSearchCustomerByPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Khách Hàng";
            // 
            // dgvDisplayCustomers
            // 
            this.dgvDisplayCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplayCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayCustomers.Location = new System.Drawing.Point(2, 128);
            this.dgvDisplayCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisplayCustomers.Name = "dgvDisplayCustomers";
            this.dgvDisplayCustomers.RowHeadersWidth = 62;
            this.dgvDisplayCustomers.RowTemplate.Height = 33;
            this.dgvDisplayCustomers.Size = new System.Drawing.Size(466, 180);
            this.dgvDisplayCustomers.TabIndex = 0;
            this.dgvDisplayCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayCustomers_RowHeaderMouseClick);
            this.dgvDisplayCustomers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayCustomers_RowHeaderMouseDoubleClick);
            // 
            // tpManageEmployees
            // 
            this.tpManageEmployees.Controls.Add(this.btnRemoveEmp);
            this.tpManageEmployees.Controls.Add(this.label8);
            this.tpManageEmployees.Controls.Add(this.txtSearchEmpByName);
            this.tpManageEmployees.Controls.Add(this.gbCreateAccount);
            this.tpManageEmployees.Controls.Add(this.dgvDisplayEmployees);
            this.tpManageEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.tpManageEmployees.Name = "tpManageEmployees";
            this.tpManageEmployees.Padding = new System.Windows.Forms.Padding(2);
            this.tpManageEmployees.Size = new System.Drawing.Size(697, 308);
            this.tpManageEmployees.TabIndex = 0;
            this.tpManageEmployees.Text = "Quản Lý Nhân Sự";
            this.tpManageEmployees.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(333, 240);
            this.btnRemoveEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(90, 66);
            this.btnRemoveEmp.TabIndex = 4;
            this.btnRemoveEmp.Text = "Kích Hoạt \r\nKhoá";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            this.btnRemoveEmp.Click += new System.EventHandler(this.txtRemoveEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tìm Nhân Viên";
            // 
            // txtSearchEmpByName
            // 
            this.txtSearchEmpByName.Location = new System.Drawing.Point(333, 210);
            this.txtSearchEmpByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchEmpByName.Name = "txtSearchEmpByName";
            this.txtSearchEmpByName.Size = new System.Drawing.Size(278, 27);
            this.txtSearchEmpByName.TabIndex = 2;
            this.txtSearchEmpByName.TextChanged += new System.EventHandler(this.txtSearchEmpByName_TextChanged);
            // 
            // gbCreateAccount
            // 
            this.gbCreateAccount.Controls.Add(this.btnCreateAccount);
            this.gbCreateAccount.Controls.Add(this.gbRole);
            this.gbCreateAccount.Controls.Add(this.txtEmpPassword);
            this.gbCreateAccount.Controls.Add(this.txtEmpUsername);
            this.gbCreateAccount.Controls.Add(this.txtEmpName);
            this.gbCreateAccount.Controls.Add(this.label7);
            this.gbCreateAccount.Controls.Add(this.label6);
            this.gbCreateAccount.Controls.Add(this.label5);
            this.gbCreateAccount.Location = new System.Drawing.Point(5, 178);
            this.gbCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.gbCreateAccount.Name = "gbCreateAccount";
            this.gbCreateAccount.Padding = new System.Windows.Forms.Padding(2);
            this.gbCreateAccount.Size = new System.Drawing.Size(323, 132);
            this.gbCreateAccount.TabIndex = 1;
            this.gbCreateAccount.TabStop = false;
            this.gbCreateAccount.Text = "Thêm Tài Khoản";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(101, 105);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(120, 27);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.rbCashier);
            this.gbRole.Controls.Add(this.rbAdmin);
            this.gbRole.Location = new System.Drawing.Point(226, 22);
            this.gbRole.Margin = new System.Windows.Forms.Padding(2);
            this.gbRole.Name = "gbRole";
            this.gbRole.Padding = new System.Windows.Forms.Padding(2);
            this.gbRole.Size = new System.Drawing.Size(93, 80);
            this.gbRole.TabIndex = 2;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // rbCashier
            // 
            this.rbCashier.AutoSize = true;
            this.rbCashier.Location = new System.Drawing.Point(5, 51);
            this.rbCashier.Margin = new System.Windows.Forms.Padding(2);
            this.rbCashier.Name = "rbCashier";
            this.rbCashier.Size = new System.Drawing.Size(78, 24);
            this.rbCashier.TabIndex = 1;
            this.rbCashier.TabStop = true;
            this.rbCashier.Text = "Cashier";
            this.rbCashier.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(5, 23);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(74, 24);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(101, 77);
            this.txtEmpPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(121, 27);
            this.txtEmpPassword.TabIndex = 1;
            // 
            // txtEmpUsername
            // 
            this.txtEmpUsername.Location = new System.Drawing.Point(101, 49);
            this.txtEmpUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpUsername.Name = "txtEmpUsername";
            this.txtEmpUsername.Size = new System.Drawing.Size(121, 27);
            this.txtEmpUsername.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(101, 22);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ShortcutsEnabled = false;
            this.txtEmpName.Size = new System.Drawing.Size(121, 27);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLetterOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // dgvDisplayEmployees
            // 
            this.dgvDisplayEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayEmployees.Location = new System.Drawing.Point(5, 5);
            this.dgvDisplayEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDisplayEmployees.Name = "dgvDisplayEmployees";
            this.dgvDisplayEmployees.RowHeadersWidth = 62;
            this.dgvDisplayEmployees.RowTemplate.Height = 33;
            this.dgvDisplayEmployees.Size = new System.Drawing.Size(605, 169);
            this.dgvDisplayEmployees.TabIndex = 0;
            this.dgvDisplayEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayEmployees_RowHeaderMouseClick);
            this.dgvDisplayEmployees.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayEmployees_RowHeaderMouseDoubleClick);
            // 
            // tpRevenue
            // 
            this.tpRevenue.Controls.Add(this.btnReset);
            this.tpRevenue.Controls.Add(this.dgvRevenue);
            this.tpRevenue.Controls.Add(this.txtRevenue);
            this.tpRevenue.Controls.Add(this.label10);
            this.tpRevenue.Controls.Add(this.label9);
            this.tpRevenue.Controls.Add(this.btnSearchRevenueByDate);
            this.tpRevenue.Controls.Add(this.dtpEnd);
            this.tpRevenue.Controls.Add(this.dtpStart);
            this.tpRevenue.Location = new System.Drawing.Point(4, 29);
            this.tpRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.tpRevenue.Name = "tpRevenue";
            this.tpRevenue.Size = new System.Drawing.Size(661, 308);
            this.tpRevenue.TabIndex = 4;
            this.tpRevenue.Text = "Doanh Thu";
            this.tpRevenue.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(515, 36);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(2, 100);
            this.dgvRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 62;
            this.dgvRevenue.RowTemplate.Height = 33;
            this.dgvRevenue.Size = new System.Drawing.Size(655, 180);
            this.dgvRevenue.TabIndex = 6;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(402, 283);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(255, 27);
            this.txtRevenue.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng Doanh Thu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(179, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doanh Thu Cửa Hàng ";
            // 
            // btnSearchRevenueByDate
            // 
            this.btnSearchRevenueByDate.Location = new System.Drawing.Point(515, 68);
            this.btnSearchRevenueByDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRevenueByDate.Name = "btnSearchRevenueByDate";
            this.btnSearchRevenueByDate.Size = new System.Drawing.Size(90, 27);
            this.btnSearchRevenueByDate.TabIndex = 2;
            this.btnSearchRevenueByDate.Text = "Search";
            this.btnSearchRevenueByDate.UseVisualStyleBackColor = true;
            this.btnSearchRevenueByDate.Click += new System.EventHandler(this.btnSearchRenevueByDate_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(259, 70);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(238, 27);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.Value = new System.DateTime(2023, 2, 1, 11, 30, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(2, 70);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(238, 27);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.Value = new System.DateTime(2023, 1, 5, 11, 30, 0, 0);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(538, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 27);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(652, 314);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(19, 15);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 386);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.btnCheck);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tcMain.ResumeLayout(false);
            this.tpTransaction.ResumeLayout(false);
            this.tpTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            this.tpStorage.ResumeLayout(false);
            this.tpStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStorage)).EndInit();
            this.tpCustomer.ResumeLayout(false);
            this.tpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomers)).EndInit();
            this.tpManageEmployees.ResumeLayout(false);
            this.tpManageEmployees.PerformLayout();
            this.gbCreateAccount.ResumeLayout(false);
            this.gbCreateAccount.PerformLayout();
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmployees)).EndInit();
            this.tpRevenue.ResumeLayout(false);
            this.tpRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcMain;
        private TabPage tpManageEmployees;
        private TabPage tpStorage;
        private TabPage tpCustomer;
        private TextBox txtSearchByName;
        private Label label1;
        private DataGridView dgvDisplayStorage;
        private Button btnAddNew;
        private Button btnEdit;
        private Button btnRemoveCustomer;
        private Button btnEditCustomer;
        private Button btnAdd;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private TextBox txtSearchCustomerByPhone;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvDisplayCustomers;
        private TabPage tpTransaction;
        private GroupBox gbCreateAccount;
        private GroupBox gbRole;
        private RadioButton rbCashier;
        private RadioButton rbAdmin;
        private TextBox txtEmpPassword;
        private TextBox txtEmpUsername;
        private TextBox txtEmpName;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvDisplayEmployees;
        private Button btnCreateAccount;
        private Button btnRemoveEmp;
        private Label label8;
        private TextBox txtSearchEmpByName;
        private Button btnStorageF5;
        private TabPage tpRevenue;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private TextBox txtRevenue;
        private Label label10;
        private Label label9;
        private Button btnSearchRevenueByDate;
        private DataGridView dgvRevenue;
        private Button btnReset;
        private TextBox txtSearchPrice;
        private TextBox txtSearchProduct;
        private DataGridView dgvBasket;
        private TextBox txtSearchAmount;
        private Button btnAddToBasket;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TotalPrice;
        private Button btnCheckOut;
        private TextBox txtTp1CustomerName;
        private TextBox txtTp1CustomerPhone;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnLogout;
        private Button btnCheck;
    }
}