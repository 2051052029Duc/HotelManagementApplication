namespace GUI_Hotel
{
    partial class frmRoom
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
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Room_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_order_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_floor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_type_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.cbTypeRoom = new System.Windows.Forms.ComboBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 47);
            this.toolStrip1.TabIndex = 1;
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
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // bthThoat
            // 
            this.bthThoat.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.bthThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(51, 44);
            this.bthThoat.Text = "Thoát";
            this.bthThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1030, 246);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gcDanhSach_FocusedViewChanged);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvDanhSach.Appearance.Row.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Room_id,
            this.Room_num,
            this.Room_status,
            this.Room_order_id,
            this.Room_floor_id,
            this.Room_type_id});
            this.gvDanhSach.DetailHeight = 431;
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.Editable = false;
            this.gvDanhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhSach_FocusedRowChanged);
            // 
            // Room_id
            // 
            this.Room_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_id.AppearanceCell.Options.UseFont = true;
            this.Room_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_id.AppearanceHeader.Options.UseFont = true;
            this.Room_id.Caption = "Mã phòng";
            this.Room_id.FieldName = "Room_id";
            this.Room_id.MinWidth = 23;
            this.Room_id.Name = "Room_id";
            this.Room_id.Visible = true;
            this.Room_id.VisibleIndex = 0;
            this.Room_id.Width = 87;
            // 
            // Room_num
            // 
            this.Room_num.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_num.AppearanceCell.Options.UseFont = true;
            this.Room_num.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_num.AppearanceHeader.Options.UseFont = true;
            this.Room_num.Caption = "Số phòng";
            this.Room_num.FieldName = "Room_num";
            this.Room_num.MinWidth = 23;
            this.Room_num.Name = "Room_num";
            this.Room_num.Visible = true;
            this.Room_num.VisibleIndex = 1;
            this.Room_num.Width = 87;
            // 
            // Room_status
            // 
            this.Room_status.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_status.AppearanceCell.Options.UseFont = true;
            this.Room_status.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_status.AppearanceHeader.Options.UseFont = true;
            this.Room_status.Caption = "Trạng thái";
            this.Room_status.FieldName = "Room_status";
            this.Room_status.MinWidth = 23;
            this.Room_status.Name = "Room_status";
            this.Room_status.Visible = true;
            this.Room_status.VisibleIndex = 2;
            this.Room_status.Width = 87;
            // 
            // Room_order_id
            // 
            this.Room_order_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_order_id.AppearanceCell.Options.UseFont = true;
            this.Room_order_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_order_id.AppearanceHeader.Options.UseFont = true;
            this.Room_order_id.Caption = "Mã hoá đơn phòng";
            this.Room_order_id.FieldName = "Room_order_id";
            this.Room_order_id.MinWidth = 23;
            this.Room_order_id.Name = "Room_order_id";
            this.Room_order_id.Visible = true;
            this.Room_order_id.VisibleIndex = 3;
            this.Room_order_id.Width = 87;
            // 
            // Room_floor_id
            // 
            this.Room_floor_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_floor_id.AppearanceCell.Options.UseFont = true;
            this.Room_floor_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_floor_id.AppearanceHeader.Options.UseFont = true;
            this.Room_floor_id.Caption = "Mã tầng";
            this.Room_floor_id.FieldName = "Room_floor_id";
            this.Room_floor_id.MinWidth = 23;
            this.Room_floor_id.Name = "Room_floor_id";
            this.Room_floor_id.Visible = true;
            this.Room_floor_id.VisibleIndex = 4;
            this.Room_floor_id.Width = 87;
            // 
            // Room_type_id
            // 
            this.Room_type_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_type_id.AppearanceCell.Options.UseFont = true;
            this.Room_type_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_type_id.AppearanceHeader.Options.UseFont = true;
            this.Room_type_id.Caption = "Mã loại phòng";
            this.Room_type_id.FieldName = "Room_type_id";
            this.Room_type_id.MinWidth = 23;
            this.Room_type_id.Name = "Room_type_id";
            this.Room_type_id.Visible = true;
            this.Room_type_id.VisibleIndex = 5;
            this.Room_type_id.Width = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tầng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại phòng:";
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(135, 320);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(116, 30);
            this.txtNum.TabIndex = 7;
            // 
            // cbFloor
            // 
            this.cbFloor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Location = new System.Drawing.Point(440, 320);
            this.cbFloor.Margin = new System.Windows.Forms.Padding(4);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(186, 31);
            this.cbFloor.TabIndex = 8;
            this.cbFloor.SelectedIndexChanged += new System.EventHandler(this.cbFloor_SelectedIndexChanged);
            // 
            // cbTypeRoom
            // 
            this.cbTypeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeRoom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeRoom.FormattingEnabled = true;
            this.cbTypeRoom.Location = new System.Drawing.Point(865, 320);
            this.cbTypeRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeRoom.Name = "cbTypeRoom";
            this.cbTypeRoom.Size = new System.Drawing.Size(140, 31);
            this.cbTypeRoom.TabIndex = 9;
            this.cbTypeRoom.SelectedIndexChanged += new System.EventHandler(this.cbTypeRoom_SelectedIndexChanged);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatus.Location = new System.Drawing.Point(141, 376);
            this.checkBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(114, 27);
            this.checkBoxStatus.TabIndex = 10;
            this.checkBoxStatus.Text = "Khả dụng";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 421);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.cbTypeRoom);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton bthThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.ComboBox cbTypeRoom;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Room_id;
        private DevExpress.XtraGrid.Columns.GridColumn Room_num;
        private DevExpress.XtraGrid.Columns.GridColumn Room_status;
        private DevExpress.XtraGrid.Columns.GridColumn Room_order_id;
        private DevExpress.XtraGrid.Columns.GridColumn Room_floor_id;
        private DevExpress.XtraGrid.Columns.GridColumn Room_type_id;
    }
}