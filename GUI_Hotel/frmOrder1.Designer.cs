namespace GUI_Hotel
{
    partial class frmOrder1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchCus = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Customer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumCus = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 47);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1294, 653);
            this.splitContainerControl1.SplitterPosition = 864;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(714, 613);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl5.Appearance.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.txtTotalAmount);
            this.groupControl5.Controls.Add(this.lb);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(0, 508);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(864, 86);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "Tổng tiền";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(164, 42);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.gcSanPhamDat);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 250);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(864, 258);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Danh sách sản phẩm - dịch vụ đặt";
            // 
            // gcSanPhamDat
            // 
            this.gcSanPhamDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPhamDat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSanPhamDat.Location = new System.Drawing.Point(2, 28);
            this.gcSanPhamDat.MainView = this.gvSanPhamDat;
            this.gcSanPhamDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSanPhamDat.Name = "gcSanPhamDat";
            this.gcSanPhamDat.Size = new System.Drawing.Size(860, 228);
            this.gcSanPhamDat.TabIndex = 0;
            this.gcSanPhamDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamDat});
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
            this.gvSanPhamDat.HiddenEditor += new System.EventHandler(this.gvSanPhamDat_HiddenEditor);
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
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.searchCus);
            this.groupControl1.Controls.Add(this.txtNumCus);
            this.groupControl1.Controls.Add(this.txtNote);
            this.groupControl1.Controls.Add(this.dpCheckout);
            this.groupControl1.Controls.Add(this.dpCheckin);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnAddCustomer);
            this.groupControl1.Controls.Add(this.cbStatus);
            this.groupControl1.Controls.Add(this.lbRoomNum);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(864, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // searchCus
            // 
            this.searchCus.Location = new System.Drawing.Point(268, 90);
            this.searchCus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchCus.Name = "searchCus";
            this.searchCus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCus.Properties.Appearance.Options.UseFont = true;
            this.searchCus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCus.Properties.NullText = "";
            this.searchCus.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchCus.Size = new System.Drawing.Size(368, 24);
            this.searchCus.TabIndex = 22;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Customer_id,
            this.Customer_name});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Customer_id
            // 
            this.Customer_id.Caption = "ID";
            this.Customer_id.FieldName = "Customer_id";
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Visible = true;
            this.Customer_id.VisibleIndex = 0;
            // 
            // Customer_name
            // 
            this.Customer_name.Caption = "Tên khách hàng";
            this.Customer_name.FieldName = "Customer_name";
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.Visible = true;
            this.Customer_name.VisibleIndex = 1;
            // 
            // txtNumCus
            // 
            this.txtNumCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumCus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCus.Location = new System.Drawing.Point(517, 167);
            this.txtNumCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumCus.MaxLength = 3;
            this.txtNumCus.Name = "txtNumCus";
            this.txtNumCus.Size = new System.Drawing.Size(156, 26);
            this.txtNumCus.TabIndex = 20;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(268, 202);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(406, 26);
            this.txtNote.TabIndex = 21;
            // 
            // dpCheckout
            // 
            this.dpCheckout.CustomFormat = "dd/MM/yyyy";
            this.dpCheckout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCheckout.Location = new System.Drawing.Point(517, 130);
            this.dpCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpCheckout.Name = "dpCheckout";
            this.dpCheckout.Size = new System.Drawing.Size(156, 26);
            this.dpCheckout.TabIndex = 17;
            // 
            // dpCheckin
            // 
            this.dpCheckin.CustomFormat = "dd/MM/yyyy";
            this.dpCheckin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCheckin.Location = new System.Drawing.Point(268, 130);
            this.dpCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpCheckin.Name = "dpCheckin";
            this.dpCheckin.Size = new System.Drawing.Size(156, 26);
            this.dpCheckin.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày trả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số khách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ghi chú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trạng thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày đặt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Appearance.Options.UseFont = true;
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(642, 90);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(31, 28);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(268, 167);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(154, 26);
            this.cbStatus.TabIndex = 9;
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNum.ForeColor = System.Drawing.Color.Red;
            this.lbRoomNum.Location = new System.Drawing.Point(318, 37);
            this.lbRoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(104, 34);
            this.lbRoomNum.TabIndex = 8;
            this.lbRoomNum.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Khách hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(418, 653);
            this.groupControl2.TabIndex = 2;
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
            this.gcSanPham.Size = new System.Drawing.Size(414, 623);
            this.gcSanPham.TabIndex = 0;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
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
            this.gvSanPham.DoubleClick += new System.EventHandler(this.gvSanPham_DoubleClick);
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
            // frmOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 700);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmOrder1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng đơn";
            this.Load += new System.EventHandler(this.frmOrder1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPhamDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bthThoat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtNumCus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dpCheckout;
        private System.Windows.Forms.DateTimePicker dpCheckin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRoomNum;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSanPhamDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamDat;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_name;
        private DevExpress.XtraGrid.Columns.GridColumn Book_product_id;
        private DevExpress.XtraGrid.Columns.GridColumn Book_product_name;
        private DevExpress.XtraGrid.Columns.GridColumn prod_qty;
        private DevExpress.XtraGrid.Columns.GridColumn prod_price;
        private DevExpress.XtraGrid.Columns.GridColumn Book_total_amount;
        private DevExpress.XtraGrid.Columns.GridColumn Book_room_prod_id;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn Product_id;
        private DevExpress.XtraGrid.Columns.GridColumn Product_name;
        private DevExpress.XtraGrid.Columns.GridColumn Product_price;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lb;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCus;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_id;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_name;
    }
}