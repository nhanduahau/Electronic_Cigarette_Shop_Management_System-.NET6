namespace ShopVape_Cleanup_Framwork_6_
{
    partial class EditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.txtOldPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddAmount = new System.Windows.Forms.TextBox();
            this.txtOriginalAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(51, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên Sản Phẩm";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 25);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(288, 31);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNewPrice);
            this.groupBox2.Controls.Add(this.txtOldPrice);
            this.groupBox2.Location = new System.Drawing.Point(51, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá mới";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(6, 113);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.ShortcutsEnabled = false;
            this.txtNewPrice.Size = new System.Drawing.Size(288, 31);
            this.txtNewPrice.TabIndex = 0;
            this.txtNewPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPrice_KeyPress);
            // 
            // txtOldPrice
            // 
            this.txtOldPrice.Location = new System.Drawing.Point(6, 30);
            this.txtOldPrice.Name = "txtOldPrice";
            this.txtOldPrice.ReadOnly = true;
            this.txtOldPrice.Size = new System.Drawing.Size(288, 31);
            this.txtOldPrice.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAddAmount);
            this.groupBox3.Controls.Add(this.txtOriginalAmount);
            this.groupBox3.Location = new System.Drawing.Point(389, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 150);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số Lượng Tồn Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hàng vào kho";
            // 
            // txtAddAmount
            // 
            this.txtAddAmount.Location = new System.Drawing.Point(6, 113);
            this.txtAddAmount.Name = "txtAddAmount";
            this.txtAddAmount.ShortcutsEnabled = false;
            this.txtAddAmount.Size = new System.Drawing.Size(288, 31);
            this.txtAddAmount.TabIndex = 0;
            this.txtAddAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddAmount_KeyPress);
            // 
            // txtOriginalAmount
            // 
            this.txtOriginalAmount.Location = new System.Drawing.Point(6, 30);
            this.txtOriginalAmount.Name = "txtOriginalAmount";
            this.txtOriginalAmount.ReadOnly = true;
            this.txtOriginalAmount.Size = new System.Drawing.Size(288, 31);
            this.txtOriginalAmount.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(389, 71);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(571, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private GroupBox groupBox2;
        private TextBox txtNewPrice;
        private TextBox txtOldPrice;
        private GroupBox groupBox3;
        private TextBox txtAddAmount;
        private TextBox txtOriginalAmount;
        private Button btnConfirm;
        private Button btnExit;
        private Label label1;
        private Label label2;
    }
}