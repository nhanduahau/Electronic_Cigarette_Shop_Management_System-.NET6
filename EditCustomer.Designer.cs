namespace ShopVape_Cleanup_Framwork_6_
{
    partial class EditCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOldPhone = new System.Windows.Forms.TextBox();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbOld = new System.Windows.Forms.GroupBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.gbOld.SuspendLayout();
            this.gbNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // tbOldPhone
            // 
            this.tbOldPhone.Location = new System.Drawing.Point(150, 39);
            this.tbOldPhone.Name = "tbOldPhone";
            this.tbOldPhone.ReadOnly = true;
            this.tbOldPhone.Size = new System.Drawing.Size(309, 31);
            this.tbOldPhone.TabIndex = 2;
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(150, 79);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.ReadOnly = true;
            this.tbOldName.Size = new System.Drawing.Size(309, 31);
            this.tbOldName.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(83, 331);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "SĐT";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(150, 38);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(309, 31);
            this.tbPhone.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 31);
            this.tbName.TabIndex = 3;
            // 
            // gbOld
            // 
            this.gbOld.Controls.Add(this.label1);
            this.gbOld.Controls.Add(this.label2);
            this.gbOld.Controls.Add(this.tbOldPhone);
            this.gbOld.Controls.Add(this.tbOldName);
            this.gbOld.Location = new System.Drawing.Point(83, 29);
            this.gbOld.Name = "gbOld";
            this.gbOld.Size = new System.Drawing.Size(470, 113);
            this.gbOld.TabIndex = 6;
            this.gbOld.TabStop = false;
            this.gbOld.Text = "Cũ";
            // 
            // gbNew
            // 
            this.gbNew.Controls.Add(this.label4);
            this.gbNew.Controls.Add(this.label3);
            this.gbNew.Controls.Add(this.tbName);
            this.gbNew.Controls.Add(this.tbPhone);
            this.gbNew.Location = new System.Drawing.Point(83, 162);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(470, 150);
            this.gbNew.TabIndex = 7;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "Mới";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 399);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.gbOld);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.gbOld.ResumeLayout(false);
            this.gbOld.PerformLayout();
            this.gbNew.ResumeLayout(false);
            this.gbNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbOldPhone;
        private TextBox tbOldName;
        private Button btnConfirm;
        private Button btnExit;
        private Label label3;
        private Label label4;
        private TextBox tbPhone;
        private TextBox tbName;
        private GroupBox gbOld;
        private GroupBox gbNew;
    }
}