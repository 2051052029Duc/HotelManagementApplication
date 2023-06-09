namespace GUI_Hotel
{
    partial class frmEmployee
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Employee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmloyeePassword = new System.Windows.Forms.TextBox();
            this.txtEmloyeeUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_Hotel.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_Hotel.Properties.Resources.update;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_Hotel.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 47);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(856, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 72);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(856, 313);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDanhSach.Appearance.Preview.Options.UseFont = true;
            this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvDanhSach.Appearance.Row.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Employee_id,
            this.Employee_name,
            this.Employee_gender,
            this.Employee_phone,
            this.Employee_email,
            this.Employee_username,
            this.Employee_password});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.Editable = false;
            this.gvDanhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhSach_FocusedRowChanged);
            // 
            // Employee_id
            // 
            this.Employee_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_id.AppearanceHeader.Options.UseFont = true;
            this.Employee_id.Caption = "Mã Nhân Viên";
            this.Employee_id.FieldName = "Employee_id";
            this.Employee_id.MinWidth = 24;
            this.Employee_id.Name = "Employee_id";
            this.Employee_id.Visible = true;
            this.Employee_id.VisibleIndex = 0;
            this.Employee_id.Width = 94;
            // 
            // Employee_name
            // 
            this.Employee_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_name.AppearanceHeader.Options.UseFont = true;
            this.Employee_name.Caption = "Tên Nhân Viên";
            this.Employee_name.FieldName = "Employee_name";
            this.Employee_name.MinWidth = 24;
            this.Employee_name.Name = "Employee_name";
            this.Employee_name.Visible = true;
            this.Employee_name.VisibleIndex = 1;
            this.Employee_name.Width = 94;
            // 
            // Employee_gender
            // 
            this.Employee_gender.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_gender.AppearanceHeader.Options.UseFont = true;
            this.Employee_gender.Caption = "Giới tính";
            this.Employee_gender.FieldName = "Employee_gender";
            this.Employee_gender.MinWidth = 24;
            this.Employee_gender.Name = "Employee_gender";
            this.Employee_gender.Visible = true;
            this.Employee_gender.VisibleIndex = 2;
            this.Employee_gender.Width = 94;
            // 
            // Employee_phone
            // 
            this.Employee_phone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_phone.AppearanceHeader.Options.UseFont = true;
            this.Employee_phone.Caption = "Điện thoại";
            this.Employee_phone.FieldName = "Employee_phone";
            this.Employee_phone.MinWidth = 24;
            this.Employee_phone.Name = "Employee_phone";
            this.Employee_phone.Visible = true;
            this.Employee_phone.VisibleIndex = 3;
            this.Employee_phone.Width = 94;
            // 
            // Employee_email
            // 
            this.Employee_email.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_email.AppearanceHeader.Options.UseFont = true;
            this.Employee_email.Caption = "Email";
            this.Employee_email.FieldName = "Employee_email";
            this.Employee_email.MinWidth = 24;
            this.Employee_email.Name = "Employee_email";
            this.Employee_email.Visible = true;
            this.Employee_email.VisibleIndex = 4;
            this.Employee_email.Width = 94;
            // 
            // Employee_username
            // 
            this.Employee_username.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_username.AppearanceHeader.Options.UseFont = true;
            this.Employee_username.Caption = "Tài khoản";
            this.Employee_username.FieldName = "Employee_username";
            this.Employee_username.MinWidth = 24;
            this.Employee_username.Name = "Employee_username";
            this.Employee_username.Visible = true;
            this.Employee_username.VisibleIndex = 5;
            this.Employee_username.Width = 94;
            // 
            // Employee_password
            // 
            this.Employee_password.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Employee_password.AppearanceHeader.Options.UseFont = true;
            this.Employee_password.Caption = "Mật khẩu";
            this.Employee_password.FieldName = "Employee_password";
            this.Employee_password.MinWidth = 24;
            this.Employee_password.Name = "Employee_password";
            this.Employee_password.Visible = true;
            this.Employee_password.VisibleIndex = 6;
            this.Employee_password.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtEmloyeePassword);
            this.groupControl1.Controls.Add(this.txtEmloyeeUserName);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.txtEmployeePhone);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtEmployeeEmail);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtEmployeeName);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 385);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(856, 201);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtEmloyeePassword
            // 
            this.txtEmloyeePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmloyeePassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmloyeePassword.Location = new System.Drawing.Point(166, 151);
            this.txtEmloyeePassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmloyeePassword.Name = "txtEmloyeePassword";
            this.txtEmloyeePassword.Size = new System.Drawing.Size(267, 30);
            this.txtEmloyeePassword.TabIndex = 20;
            // 
            // txtEmloyeeUserName
            // 
            this.txtEmloyeeUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmloyeeUserName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmloyeeUserName.Location = new System.Drawing.Point(166, 114);
            this.txtEmloyeeUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmloyeeUserName.Name = "txtEmloyeeUserName";
            this.txtEmloyeeUserName.Size = new System.Drawing.Size(267, 30);
            this.txtEmloyeeUserName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(26, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tài khoản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Location = new System.Drawing.Point(578, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 34);
            this.panel1.TabIndex = 15;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdNu.Location = new System.Drawing.Point(74, 4);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(56, 27);
            this.rdNu.TabIndex = 14;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdNam.Location = new System.Drawing.Point(4, 4);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(70, 27);
            this.rdNam.TabIndex = 13;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeePhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmployeePhone.Location = new System.Drawing.Point(578, 41);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(267, 30);
            this.txtEmployeePhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(476, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmployeeEmail.Location = new System.Drawing.Point(166, 78);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(267, 30);
            this.txtEmployeeEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(476, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điện thoại:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmployeeName.Location = new System.Drawing.Point(166, 41);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(267, 30);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(26, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên:";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 586);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_id;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_name;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_gender;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_phone;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_email;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_username;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txtEmloyeePassword;
        private System.Windows.Forms.TextBox txtEmloyeeUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}