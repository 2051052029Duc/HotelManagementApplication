namespace GUI_Hotel
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
            this.tabDanhSach = new DevExpress.XtraTab.XtraTabControl();
            this.pageOrders = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Order_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_checkin_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_checkout_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_total_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_num_of_cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_is_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_customer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_employee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_name_cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_rooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pageOrderDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Room_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Floor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Floor_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbCancel = new System.Windows.Forms.Label();
            this.txtNumCus = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.chkIsGroup = new System.Windows.Forms.CheckBox();
            this.dpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPhamDat = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Book_room_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_product_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_product_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prod_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prod_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_total_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_room_prod_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhongDat = new DevExpress.XtraGrid.GridControl();
            this.gvPhongDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Book_room_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_room_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_floor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_floor_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_typeroom_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Book_orderDetail_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDanhSach)).BeginInit();
            this.tabDanhSach.SuspendLayout();
            this.pageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.pageOrderDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhongDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongDat)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1298, 47);
            this.toolStrip1.TabIndex = 2;
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
            // tabDanhSach
            // 
            this.tabDanhSach.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tabDanhSach.Appearance.Options.UseFont = true;
            this.tabDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDanhSach.Location = new System.Drawing.Point(0, 47);
            this.tabDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.SelectedTabPage = this.pageOrders;
            this.tabDanhSach.Size = new System.Drawing.Size(1298, 898);
            this.tabDanhSach.TabIndex = 3;
            this.tabDanhSach.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageOrders,
            this.pageOrderDetails});
            this.tabDanhSach.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.tabDanhSach_SelectedPageChanging);
            // 
            // pageOrders
            // 
            this.pageOrders.Controls.Add(this.splitContainerControl1);
            this.pageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.pageOrders.Name = "pageOrders";
            this.pageOrders.Size = new System.Drawing.Size(1296, 868);
            this.pageOrders.Text = "Danh sách";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.dpTo);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dpFrom);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1296, 868);
            this.splitContainerControl1.SplitterPosition = 60;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // dpTo
            // 
            this.dpTo.CustomFormat = "dd/MM/yyyy";
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTo.Location = new System.Drawing.Point(766, 16);
            this.dpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(210, 30);
            this.dpTo.TabIndex = 1;
            this.dpTo.Value = new System.DateTime(2023, 4, 22, 15, 54, 54, 0);
            this.dpTo.ValueChanged += new System.EventHandler(this.dpTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(668, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpFrom
            // 
            this.dpFrom.CustomFormat = "dd/MM/yyyy";
            this.dpFrom.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFrom.Location = new System.Drawing.Point(360, 16);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(210, 30);
            this.dpFrom.TabIndex = 1;
            this.dpFrom.Value = new System.DateTime(2023, 4, 1, 0, 0, 0, 0);
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(272, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1296, 796);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvDanhSach.Appearance.Row.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Order_id,
            this.Order_checkin_date,
            this.Order_checkout_date,
            this.Order_total_amount,
            this.Order_num_of_cus,
            this.Order_status,
            this.Order_is_group,
            this.Order_note,
            this.Order_customer_id,
            this.Order_employee_id,
            this.Order_name_cus,
            this.Order_rooms});
            this.gvDanhSach.DetailHeight = 431;
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.Editable = false;
            this.gvDanhSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvDanhSach_MouseDown);
            // 
            // Order_id
            // 
            this.Order_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_id.AppearanceCell.Options.UseFont = true;
            this.Order_id.Caption = "Mã đặt phòng";
            this.Order_id.FieldName = "Order_id";
            this.Order_id.MinWidth = 23;
            this.Order_id.Name = "Order_id";
            this.Order_id.Visible = true;
            this.Order_id.VisibleIndex = 0;
            this.Order_id.Width = 87;
            // 
            // Order_checkin_date
            // 
            this.Order_checkin_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_checkin_date.AppearanceCell.Options.UseFont = true;
            this.Order_checkin_date.Caption = "Ngày đặt phòng";
            this.Order_checkin_date.FieldName = "Order_checkin_date";
            this.Order_checkin_date.MinWidth = 24;
            this.Order_checkin_date.Name = "Order_checkin_date";
            this.Order_checkin_date.Visible = true;
            this.Order_checkin_date.VisibleIndex = 1;
            this.Order_checkin_date.Width = 87;
            // 
            // Order_checkout_date
            // 
            this.Order_checkout_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_checkout_date.AppearanceCell.Options.UseFont = true;
            this.Order_checkout_date.Caption = "Ngày trả phòng";
            this.Order_checkout_date.FieldName = "Order_checkout_date";
            this.Order_checkout_date.MinWidth = 24;
            this.Order_checkout_date.Name = "Order_checkout_date";
            this.Order_checkout_date.Visible = true;
            this.Order_checkout_date.VisibleIndex = 2;
            this.Order_checkout_date.Width = 87;
            // 
            // Order_total_amount
            // 
            this.Order_total_amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_total_amount.AppearanceCell.Options.UseFont = true;
            this.Order_total_amount.Caption = "Tổng tiền";
            this.Order_total_amount.FieldName = "Order_total_amount";
            this.Order_total_amount.MinWidth = 24;
            this.Order_total_amount.Name = "Order_total_amount";
            this.Order_total_amount.Visible = true;
            this.Order_total_amount.VisibleIndex = 3;
            this.Order_total_amount.Width = 87;
            // 
            // Order_num_of_cus
            // 
            this.Order_num_of_cus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_num_of_cus.AppearanceCell.Options.UseFont = true;
            this.Order_num_of_cus.Caption = "Số lượng khách";
            this.Order_num_of_cus.FieldName = "Order_num_of_cus";
            this.Order_num_of_cus.MinWidth = 24;
            this.Order_num_of_cus.Name = "Order_num_of_cus";
            this.Order_num_of_cus.Visible = true;
            this.Order_num_of_cus.VisibleIndex = 4;
            this.Order_num_of_cus.Width = 87;
            // 
            // Order_status
            // 
            this.Order_status.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_status.AppearanceCell.Options.UseFont = true;
            this.Order_status.Caption = "Trạng thái";
            this.Order_status.FieldName = "Order_status";
            this.Order_status.MinWidth = 24;
            this.Order_status.Name = "Order_status";
            this.Order_status.Visible = true;
            this.Order_status.VisibleIndex = 9;
            this.Order_status.Width = 87;
            // 
            // Order_is_group
            // 
            this.Order_is_group.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_is_group.AppearanceCell.Options.UseFont = true;
            this.Order_is_group.Caption = "Đặt theo đoàn";
            this.Order_is_group.FieldName = "Order_is_group";
            this.Order_is_group.MinWidth = 24;
            this.Order_is_group.Name = "Order_is_group";
            this.Order_is_group.Visible = true;
            this.Order_is_group.VisibleIndex = 6;
            this.Order_is_group.Width = 87;
            // 
            // Order_note
            // 
            this.Order_note.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_note.AppearanceCell.Options.UseFont = true;
            this.Order_note.Caption = "Ghi chú";
            this.Order_note.FieldName = "Order_note";
            this.Order_note.MinWidth = 24;
            this.Order_note.Name = "Order_note";
            this.Order_note.Visible = true;
            this.Order_note.VisibleIndex = 5;
            this.Order_note.Width = 87;
            // 
            // Order_customer_id
            // 
            this.Order_customer_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_customer_id.AppearanceCell.Options.UseFont = true;
            this.Order_customer_id.Caption = "Mã khách hàng";
            this.Order_customer_id.FieldName = "Order_customer_id";
            this.Order_customer_id.MinWidth = 24;
            this.Order_customer_id.Name = "Order_customer_id";
            this.Order_customer_id.Width = 87;
            // 
            // Order_employee_id
            // 
            this.Order_employee_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_employee_id.AppearanceCell.Options.UseFont = true;
            this.Order_employee_id.Caption = "Mã nhân viên";
            this.Order_employee_id.FieldName = "Order_employee_id";
            this.Order_employee_id.MinWidth = 24;
            this.Order_employee_id.Name = "Order_employee_id";
            this.Order_employee_id.Width = 87;
            // 
            // Order_name_cus
            // 
            this.Order_name_cus.Caption = "Tên khách hàng";
            this.Order_name_cus.FieldName = "Order_name_cus";
            this.Order_name_cus.MinWidth = 25;
            this.Order_name_cus.Name = "Order_name_cus";
            this.Order_name_cus.Visible = true;
            this.Order_name_cus.VisibleIndex = 7;
            this.Order_name_cus.Width = 94;
            // 
            // Order_rooms
            // 
            this.Order_rooms.Caption = "Phòng đặt";
            this.Order_rooms.FieldName = "Order_rooms";
            this.Order_rooms.MinWidth = 25;
            this.Order_rooms.Name = "Order_rooms";
            this.Order_rooms.Visible = true;
            this.Order_rooms.VisibleIndex = 8;
            this.Order_rooms.Width = 94;
            // 
            // pageOrderDetails
            // 
            this.pageOrderDetails.Controls.Add(this.tableLayoutPanel1);
            this.pageOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pageOrderDetails.Name = "pageOrderDetails";
            this.pageOrderDetails.Size = new System.Drawing.Size(1296, 868);
            this.pageOrderDetails.Text = "Chi tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainerControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 868);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(4, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(380, 864);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách phòng trống";
            // 
            // gcPhong
            // 
            this.gcPhong.AllowDrop = true;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcPhong.Location = new System.Drawing.Point(2, 28);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(376, 834);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            this.gcPhong.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcPhong.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvPhong
            // 
            this.gvPhong.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvPhong.Appearance.Row.Options.UseFont = true;
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Room_id,
            this.Room_num,
            this.Floor_id,
            this.Floor_name,
            this.TypeRoom_price});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.GroupCount = 1;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Floor_name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseDown);
            this.gvPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseMove);
            // 
            // Room_id
            // 
            this.Room_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_id.AppearanceCell.Options.UseFont = true;
            this.Room_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_id.AppearanceHeader.Options.UseFont = true;
            this.Room_id.Caption = "ID";
            this.Room_id.FieldName = "id";
            this.Room_id.MinWidth = 24;
            this.Room_id.Name = "Room_id";
            this.Room_id.Width = 94;
            // 
            // Room_num
            // 
            this.Room_num.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_num.AppearanceCell.Options.UseFont = true;
            this.Room_num.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Room_num.AppearanceHeader.Options.UseFont = true;
            this.Room_num.Caption = "Số phòng ";
            this.Room_num.FieldName = "num";
            this.Room_num.MinWidth = 24;
            this.Room_num.Name = "Room_num";
            this.Room_num.Visible = true;
            this.Room_num.VisibleIndex = 0;
            this.Room_num.Width = 94;
            // 
            // Floor_id
            // 
            this.Floor_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Floor_id.AppearanceCell.Options.UseFont = true;
            this.Floor_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Floor_id.AppearanceHeader.Options.UseFont = true;
            this.Floor_id.Caption = "ID";
            this.Floor_id.FieldName = "id";
            this.Floor_id.MinWidth = 24;
            this.Floor_id.Name = "Floor_id";
            this.Floor_id.Width = 94;
            // 
            // Floor_name
            // 
            this.Floor_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Floor_name.AppearanceCell.Options.UseFont = true;
            this.Floor_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Floor_name.AppearanceHeader.Options.UseFont = true;
            this.Floor_name.Caption = "Tầng";
            this.Floor_name.FieldName = "name";
            this.Floor_name.MinWidth = 24;
            this.Floor_name.Name = "Floor_name";
            this.Floor_name.Visible = true;
            this.Floor_name.VisibleIndex = 1;
            this.Floor_name.Width = 94;
            // 
            // TypeRoom_price
            // 
            this.TypeRoom_price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TypeRoom_price.AppearanceCell.Options.UseFont = true;
            this.TypeRoom_price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TypeRoom_price.AppearanceHeader.Options.UseFont = true;
            this.TypeRoom_price.Caption = "Đơn giá";
            this.TypeRoom_price.FieldName = "price";
            this.TypeRoom_price.MinWidth = 23;
            this.TypeRoom_price.Name = "TypeRoom_price";
            this.TypeRoom_price.Visible = true;
            this.TypeRoom_price.VisibleIndex = 1;
            this.TypeRoom_price.Width = 87;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(975, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(317, 864);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Sản phẩm - Dịch vụ";
            // 
            // gcSanPham
            // 
            this.gcSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPham.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcSanPham.Location = new System.Drawing.Point(2, 28);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(313, 834);
            this.gcSanPham.TabIndex = 0;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            this.gcSanPham.DoubleClick += new System.EventHandler(this.gcSanPham_DoubleClick);
            // 
            // gvSanPham
            // 
            this.gvSanPham.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvSanPham.Appearance.Row.Options.UseFont = true;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Product_id,
            this.Product_name,
            this.Product_price});
            this.gvSanPham.GridControl = this.gcSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            // 
            // Product_id
            // 
            this.Product_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_id.AppearanceCell.Options.UseFont = true;
            this.Product_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_id.AppearanceHeader.Options.UseFont = true;
            this.Product_id.Caption = "Mã SP-DV";
            this.Product_id.FieldName = "Product_id";
            this.Product_id.MinWidth = 24;
            this.Product_id.Name = "Product_id";
            this.Product_id.Visible = true;
            this.Product_id.VisibleIndex = 0;
            this.Product_id.Width = 94;
            // 
            // Product_name
            // 
            this.Product_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_name.AppearanceCell.Options.UseFont = true;
            this.Product_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_name.AppearanceHeader.Options.UseFont = true;
            this.Product_name.Caption = "Tên SP - DV";
            this.Product_name.FieldName = "Product_name";
            this.Product_name.MinWidth = 24;
            this.Product_name.Name = "Product_name";
            this.Product_name.Visible = true;
            this.Product_name.VisibleIndex = 1;
            this.Product_name.Width = 94;
            // 
            // Product_price
            // 
            this.Product_price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_price.AppearanceCell.Options.UseFont = true;
            this.Product_price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Product_price.AppearanceHeader.Options.UseFont = true;
            this.Product_price.Caption = "Đơn giá";
            this.Product_price.FieldName = "Product_price";
            this.Product_price.MinWidth = 24;
            this.Product_price.Name = "Product_price";
            this.Product_price.Visible = true;
            this.Product_price.VisibleIndex = 2;
            this.Product_price.Width = 94;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(392, 2);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.lbCancel);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtNumCus);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtNote);
            this.splitContainerControl2.Panel1.Controls.Add(this.chkIsGroup);
            this.splitContainerControl2.Panel1.Controls.Add(this.dpCheckout);
            this.splitContainerControl2.Panel1.Controls.Add(this.dpCheckin);
            this.splitContainerControl2.Panel1.Controls.Add(this.label5);
            this.splitContainerControl2.Panel1.Controls.Add(this.label8);
            this.splitContainerControl2.Panel1.Controls.Add(this.label7);
            this.splitContainerControl2.Panel1.Controls.Add(this.label6);
            this.splitContainerControl2.Panel1.Controls.Add(this.label4);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnAddCustomer);
            this.splitContainerControl2.Panel1.Controls.Add(this.cbStatus);
            this.splitContainerControl2.Panel1.Controls.Add(this.cbCustomer);
            this.splitContainerControl2.Panel1.Controls.Add(this.label3);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl5);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(575, 864);
            this.splitContainerControl2.SplitterPosition = 155;
            this.splitContainerControl2.TabIndex = 2;
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.Red;
            this.lbCancel.Location = new System.Drawing.Point(542, 12);
            this.lbCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(32, 33);
            this.lbCancel.TabIndex = 7;
            this.lbCancel.Text = "*";
            // 
            // txtNumCus
            // 
            this.txtNumCus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumCus.Location = new System.Drawing.Point(362, 84);
            this.txtNumCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCus.MaxLength = 3;
            this.txtNumCus.Name = "txtNumCus";
            this.txtNumCus.Size = new System.Drawing.Size(72, 26);
            this.txtNumCus.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNote.Location = new System.Drawing.Point(113, 119);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(420, 26);
            this.txtNote.TabIndex = 6;
            // 
            // chkIsGroup
            // 
            this.chkIsGroup.AutoSize = true;
            this.chkIsGroup.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chkIsGroup.Location = new System.Drawing.Point(455, 87);
            this.chkIsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsGroup.Name = "chkIsGroup";
            this.chkIsGroup.Size = new System.Drawing.Size(102, 22);
            this.chkIsGroup.TabIndex = 5;
            this.chkIsGroup.Text = "Theo đoàn";
            this.chkIsGroup.UseVisualStyleBackColor = true;
            // 
            // dpCheckout
            // 
            this.dpCheckout.CustomFormat = "dd/MM/yyyy";
            this.dpCheckout.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dpCheckout.Location = new System.Drawing.Point(369, 48);
            this.dpCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.dpCheckout.Name = "dpCheckout";
            this.dpCheckout.Size = new System.Drawing.Size(165, 26);
            this.dpCheckout.TabIndex = 4;
            // 
            // dpCheckin
            // 
            this.dpCheckin.CustomFormat = "dd/MM/yyyy";
            this.dpCheckin.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dpCheckin.Location = new System.Drawing.Point(113, 47);
            this.dpCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.dpCheckin.Name = "dpCheckin";
            this.dpCheckin.Size = new System.Drawing.Size(156, 26);
            this.dpCheckin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(296, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày trả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(296, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số khách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(14, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ghi chú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Trạng thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đặt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(503, 7);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(31, 28);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(113, 85);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(154, 26);
            this.cbStatus.TabIndex = 1;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(113, 7);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(382, 26);
            this.cbCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khách hàng";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(460, 656);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.txtTotalAmount);
            this.groupControl5.Controls.Add(this.lb);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(0, 562);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(575, 86);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "Tổng tiền";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(164, 42);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(367, 32);
            this.txtTotalAmount.TabIndex = 7;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(27, 46);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(135, 24);
            this.lb.TabIndex = 0;
            this.lb.Text = "TỔNG TIỀN: ";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.gcSanPhamDat);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 304);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(575, 258);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Danh sách sản phẩm - dịch vụ đặt";
            // 
            // gcSanPhamDat
            // 
            this.gcSanPhamDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPhamDat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcSanPhamDat.Location = new System.Drawing.Point(2, 28);
            this.gcSanPhamDat.MainView = this.gvSanPhamDat;
            this.gcSanPhamDat.Margin = new System.Windows.Forms.Padding(4);
            this.gcSanPhamDat.Name = "gcSanPhamDat";
            this.gcSanPhamDat.Size = new System.Drawing.Size(571, 228);
            this.gcSanPhamDat.TabIndex = 0;
            this.gcSanPhamDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamDat});
            this.gcSanPhamDat.Click += new System.EventHandler(this.gcSanPhamDat_Click);
            // 
            // gvSanPhamDat
            // 
            this.gvSanPhamDat.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvSanPhamDat.Appearance.Row.Options.UseFont = true;
            this.gvSanPhamDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Book_room_name,
            this.Book_product_id,
            this.Book_product_name,
            this.prod_qty,
            this.prod_price,
            this.Book_total_amount,
            this.Book_room_prod_id});
            this.gvSanPhamDat.DetailHeight = 431;
            this.gvSanPhamDat.GridControl = this.gcSanPhamDat;
            this.gvSanPhamDat.Name = "gvSanPhamDat";
            this.gvSanPhamDat.OptionsView.ShowFooter = true;
            this.gvSanPhamDat.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSanPhamDat_CellValueChanged);
            // 
            // Book_room_name
            // 
            this.Book_room_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_name.AppearanceCell.Options.UseFont = true;
            this.Book_room_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_name.AppearanceHeader.Options.UseFont = true;
            this.Book_room_name.Caption = "Phòng";
            this.Book_room_name.FieldName = "roomNum";
            this.Book_room_name.MinWidth = 23;
            this.Book_room_name.Name = "Book_room_name";
            this.Book_room_name.OptionsColumn.AllowEdit = false;
            this.Book_room_name.Visible = true;
            this.Book_room_name.VisibleIndex = 0;
            this.Book_room_name.Width = 87;
            // 
            // Book_product_id
            // 
            this.Book_product_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_product_id.AppearanceCell.Options.UseFont = true;
            this.Book_product_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_product_id.AppearanceHeader.Options.UseFont = true;
            this.Book_product_id.Caption = "Mã SP-DV";
            this.Book_product_id.FieldName = "Product_room_id";
            this.Book_product_id.MinWidth = 23;
            this.Book_product_id.Name = "Book_product_id";
            this.Book_product_id.Width = 87;
            // 
            // Book_product_name
            // 
            this.Book_product_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_product_name.AppearanceCell.Options.UseFont = true;
            this.Book_product_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_product_name.AppearanceHeader.Options.UseFont = true;
            this.Book_product_name.Caption = "Tên SP-DV";
            this.Book_product_name.FieldName = "productName";
            this.Book_product_name.MinWidth = 23;
            this.Book_product_name.Name = "Book_product_name";
            this.Book_product_name.OptionsColumn.AllowEdit = false;
            this.Book_product_name.Visible = true;
            this.Book_product_name.VisibleIndex = 1;
            this.Book_product_name.Width = 87;
            // 
            // prod_qty
            // 
            this.prod_qty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.prod_qty.AppearanceCell.Options.UseFont = true;
            this.prod_qty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.prod_qty.AppearanceHeader.Options.UseFont = true;
            this.prod_qty.Caption = "Số lượng";
            this.prod_qty.FieldName = "productQty";
            this.prod_qty.MinWidth = 23;
            this.prod_qty.Name = "prod_qty";
            this.prod_qty.Visible = true;
            this.prod_qty.VisibleIndex = 2;
            this.prod_qty.Width = 87;
            // 
            // prod_price
            // 
            this.prod_price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.prod_price.AppearanceCell.Options.UseFont = true;
            this.prod_price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.prod_price.AppearanceHeader.Options.UseFont = true;
            this.prod_price.Caption = "Đơn giá";
            this.prod_price.FieldName = "productPrice";
            this.prod_price.MinWidth = 23;
            this.prod_price.Name = "prod_price";
            this.prod_price.OptionsColumn.AllowEdit = false;
            this.prod_price.Visible = true;
            this.prod_price.VisibleIndex = 3;
            this.prod_price.Width = 87;
            // 
            // Book_total_amount
            // 
            this.Book_total_amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_total_amount.AppearanceCell.Options.UseFont = true;
            this.Book_total_amount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_total_amount.AppearanceHeader.Options.UseFont = true;
            this.Book_total_amount.Caption = "Thành tiền";
            this.Book_total_amount.FieldName = "productTotalAmount";
            this.Book_total_amount.MinWidth = 23;
            this.Book_total_amount.Name = "Book_total_amount";
            this.Book_total_amount.OptionsColumn.AllowEdit = false;
            this.Book_total_amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "productTotalAmount", "{0:n}")});
            this.Book_total_amount.Visible = true;
            this.Book_total_amount.VisibleIndex = 4;
            this.Book_total_amount.Width = 87;
            // 
            // Book_room_prod_id
            // 
            this.Book_room_prod_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_prod_id.AppearanceCell.Options.UseFont = true;
            this.Book_room_prod_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_prod_id.AppearanceHeader.Options.UseFont = true;
            this.Book_room_prod_id.Caption = "Mã phòng";
            this.Book_room_prod_id.FieldName = "Product_room_id";
            this.Book_room_prod_id.MinWidth = 23;
            this.Book_room_prod_id.Name = "Book_room_prod_id";
            this.Book_room_prod_id.Width = 87;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcPhongDat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(575, 304);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Danh sách phòng đặt";
            // 
            // gcPhongDat
            // 
            this.gcPhongDat.AllowDrop = true;
            this.gcPhongDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhongDat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gcPhongDat.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPhongDat.Location = new System.Drawing.Point(2, 28);
            this.gcPhongDat.MainView = this.gvPhongDat;
            this.gcPhongDat.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhongDat.Name = "gcPhongDat";
            this.gcPhongDat.Size = new System.Drawing.Size(571, 274);
            this.gcPhongDat.TabIndex = 0;
            this.gcPhongDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhongDat});
            this.gcPhongDat.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcPhongDat.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvPhongDat
            // 
            this.gvPhongDat.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvPhongDat.Appearance.Row.Options.UseFont = true;
            this.gvPhongDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Book_room_id,
            this.Book_room_num,
            this.Book_floor_id,
            this.Book_floor_name,
            this.Book_typeroom_price});
            this.gvPhongDat.DetailHeight = 431;
            this.gvPhongDat.GridControl = this.gcPhongDat;
            this.gvPhongDat.Name = "gvPhongDat";
            this.gvPhongDat.OptionsView.ShowFooter = true;
            this.gvPhongDat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPhongDat_MouseDown);
            this.gvPhongDat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvPhongDat_MouseMove);
            this.gvPhongDat.RowCountChanged += new System.EventHandler(this.gvPhongDat_RowCountChanged);
            // 
            // Book_room_id
            // 
            this.Book_room_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_id.AppearanceCell.Options.UseFont = true;
            this.Book_room_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_id.AppearanceHeader.Options.UseFont = true;
            this.Book_room_id.Caption = "Mã phòng";
            this.Book_room_id.FieldName = "id";
            this.Book_room_id.MinWidth = 23;
            this.Book_room_id.Name = "Book_room_id";
            this.Book_room_id.Width = 87;
            // 
            // Book_room_num
            // 
            this.Book_room_num.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_num.AppearanceCell.Options.UseFont = true;
            this.Book_room_num.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_room_num.AppearanceHeader.Options.UseFont = true;
            this.Book_room_num.Caption = "Số phòng";
            this.Book_room_num.FieldName = "num";
            this.Book_room_num.MinWidth = 23;
            this.Book_room_num.Name = "Book_room_num";
            this.Book_room_num.Visible = true;
            this.Book_room_num.VisibleIndex = 0;
            this.Book_room_num.Width = 87;
            // 
            // Book_floor_id
            // 
            this.Book_floor_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_floor_id.AppearanceCell.Options.UseFont = true;
            this.Book_floor_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_floor_id.AppearanceHeader.Options.UseFont = true;
            this.Book_floor_id.Caption = "Mã tầng";
            this.Book_floor_id.FieldName = "id";
            this.Book_floor_id.MinWidth = 23;
            this.Book_floor_id.Name = "Book_floor_id";
            this.Book_floor_id.Width = 87;
            // 
            // Book_floor_name
            // 
            this.Book_floor_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_floor_name.AppearanceCell.Options.UseFont = true;
            this.Book_floor_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_floor_name.AppearanceHeader.Options.UseFont = true;
            this.Book_floor_name.Caption = "Tầng";
            this.Book_floor_name.FieldName = "name";
            this.Book_floor_name.MinWidth = 23;
            this.Book_floor_name.Name = "Book_floor_name";
            this.Book_floor_name.Visible = true;
            this.Book_floor_name.VisibleIndex = 1;
            this.Book_floor_name.Width = 87;
            // 
            // Book_typeroom_price
            // 
            this.Book_typeroom_price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_typeroom_price.AppearanceCell.Options.UseFont = true;
            this.Book_typeroom_price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Book_typeroom_price.AppearanceHeader.Options.UseFont = true;
            this.Book_typeroom_price.Caption = "Đơn giá";
            this.Book_typeroom_price.FieldName = "price";
            this.Book_typeroom_price.MinWidth = 23;
            this.Book_typeroom_price.Name = "Book_typeroom_price";
            this.Book_typeroom_price.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "price", "{0:n}")});
            this.Book_typeroom_price.Visible = true;
            this.Book_typeroom_price.VisibleIndex = 2;
            this.Book_typeroom_price.Width = 87;
            // 
            // Book_orderDetail_quantity
            // 
            this.Book_orderDetail_quantity.Caption = "Số lượng";
            this.Book_orderDetail_quantity.FieldName = "productQty";
            this.Book_orderDetail_quantity.Name = "Book_orderDetail_quantity";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 945);
            this.Controls.Add(this.tabDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng theo đoàn";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDanhSach)).EndInit();
            this.tabDanhSach.ResumeLayout(false);
            this.pageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.pageOrderDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            this.splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhongDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton bthThoat;
        private DevExpress.XtraTab.XtraTabControl tabDanhSach;
        private DevExpress.XtraTab.XtraTabPage pageOrders;
        private DevExpress.XtraTab.XtraTabPage pageOrderDetails;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn Order_id;
        private DevExpress.XtraGrid.Columns.GridColumn Order_checkin_date;
        private DevExpress.XtraGrid.Columns.GridColumn Order_checkout_date;
        private DevExpress.XtraGrid.Columns.GridColumn Order_total_amount;
        private DevExpress.XtraGrid.Columns.GridColumn Order_num_of_cus;
        private DevExpress.XtraGrid.Columns.GridColumn Order_status;
        private DevExpress.XtraGrid.Columns.GridColumn Order_is_group;
        private DevExpress.XtraGrid.Columns.GridColumn Order_note;
        private DevExpress.XtraGrid.Columns.GridColumn Order_customer_id;
        private DevExpress.XtraGrid.Columns.GridColumn Order_employee_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn Room_id;
        private DevExpress.XtraGrid.Columns.GridColumn Room_num;
        private DevExpress.XtraGrid.Columns.GridColumn Floor_id;
        private DevExpress.XtraGrid.Columns.GridColumn Floor_name;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn Product_id;
        private DevExpress.XtraGrid.Columns.GridColumn Product_name;
        private DevExpress.XtraGrid.Columns.GridColumn Product_price;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.DateTimePicker dpCheckin;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.CheckBox chkIsGroup;
        private System.Windows.Forms.DateTimePicker dpCheckout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcSanPhamDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamDat;
        private DevExpress.XtraGrid.GridControl gcPhongDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhongDat;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Label lb;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_id;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_num;
        private DevExpress.XtraGrid.Columns.GridColumn Book_floor_id;
        private DevExpress.XtraGrid.Columns.GridColumn Book_floor_name;
        private DevExpress.XtraGrid.Columns.GridColumn Book_typeroom_price;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_price;
        private DevExpress.XtraGrid.Columns.GridColumn Book_product_id;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_name;
        private DevExpress.XtraGrid.Columns.GridColumn Book_product_name;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_prod_id;
        private DevExpress.XtraGrid.Columns.GridColumn Book_total_amount;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtNumCus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn prod_qty;
        private DevExpress.XtraGrid.Columns.GridColumn prod_price;
        private DevExpress.XtraGrid.Columns.GridColumn Book_orderDetail_quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Order_name_cus;
        private DevExpress.XtraGrid.Columns.GridColumn Order_rooms;
    }
}