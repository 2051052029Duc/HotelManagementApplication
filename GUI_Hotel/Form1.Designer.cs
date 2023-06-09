namespace GUI_Hotel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbUser = new System.Windows.Forms.Label();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemTypeRoom = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemFloor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemRoom = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.gControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnMakeOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeRoom = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            this.gControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSystem,
            this.toolStripSeparator1,
            this.btnReport,
            this.toolStripSeparator2,
            this.btnExit,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1194, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSystem
            // 
            this.btnSystem.Image = global::GUI_Hotel.Properties.Resources.system;
            this.btnSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(78, 57);
            this.btnSystem.Text = "Hệ thống";
            this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::GUI_Hotel.Properties.Resources.chart;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(68, 57);
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 57);
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GUI_Hotel.Properties.Resources.logout;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 57);
            this.toolStripButton1.Text = "Đăng xuất";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 60);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.lbUser);
            this.splitContainerControl1.Panel1.Controls.Add(this.navMain);
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gControl);
            this.splitContainerControl1.Size = new System.Drawing.Size(1194, 469);
            this.splitContainerControl1.SplitterPosition = 271;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerControl1_Paint);
            // 
            // lbUser
            // 
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(0, 427);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(271, 42);
            this.lbUser.TabIndex = 1;
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navMain
            // 
            this.navMain.ActiveGroup = this.navBarGroup1;
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navItemTypeRoom,
            this.navItemFloor,
            this.navItemRoom,
            this.navItemEmployee,
            this.navItemCustomer,
            this.navItemOrder,
            this.navItemProduct});
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Margin = new System.Windows.Forms.Padding(4);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 271;
            this.navMain.Size = new System.Drawing.Size(271, 469);
            this.navMain.TabIndex = 0;
            this.navMain.Text = "Chức năng";
            this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chức năng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTypeRoom),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemFloor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemRoom),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemProduct)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navItemTypeRoom
            // 
            this.navItemTypeRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemTypeRoom.Appearance.Options.UseFont = true;
            this.navItemTypeRoom.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemTypeRoom.AppearanceDisabled.Options.UseFont = true;
            this.navItemTypeRoom.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemTypeRoom.AppearanceHotTracked.Options.UseFont = true;
            this.navItemTypeRoom.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemTypeRoom.AppearancePressed.Options.UseFont = true;
            this.navItemTypeRoom.Caption = "Quản lý loại phòng";
            this.navItemTypeRoom.Name = "navItemTypeRoom";
            // 
            // navItemFloor
            // 
            this.navItemFloor.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemFloor.Appearance.Options.UseFont = true;
            this.navItemFloor.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemFloor.AppearanceDisabled.Options.UseFont = true;
            this.navItemFloor.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemFloor.AppearanceHotTracked.Options.UseFont = true;
            this.navItemFloor.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemFloor.AppearancePressed.Options.UseFont = true;
            this.navItemFloor.Caption = "Quản lý tầng";
            this.navItemFloor.Name = "navItemFloor";
            // 
            // navItemRoom
            // 
            this.navItemRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemRoom.Appearance.Options.UseFont = true;
            this.navItemRoom.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemRoom.AppearanceDisabled.Options.UseFont = true;
            this.navItemRoom.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemRoom.AppearanceHotTracked.Options.UseFont = true;
            this.navItemRoom.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemRoom.AppearancePressed.Options.UseFont = true;
            this.navItemRoom.Caption = "Quản lý phòng";
            this.navItemRoom.Name = "navItemRoom";
            // 
            // navItemEmployee
            // 
            this.navItemEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemEmployee.Appearance.Options.UseFont = true;
            this.navItemEmployee.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemEmployee.AppearanceDisabled.Options.UseFont = true;
            this.navItemEmployee.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemEmployee.AppearanceHotTracked.Options.UseFont = true;
            this.navItemEmployee.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemEmployee.AppearancePressed.Options.UseFont = true;
            this.navItemEmployee.Caption = "Quản lý nhân viên";
            this.navItemEmployee.Name = "navItemEmployee";
            // 
            // navItemCustomer
            // 
            this.navItemCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemCustomer.Appearance.Options.UseFont = true;
            this.navItemCustomer.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemCustomer.AppearanceDisabled.Options.UseFont = true;
            this.navItemCustomer.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemCustomer.AppearanceHotTracked.Options.UseFont = true;
            this.navItemCustomer.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemCustomer.AppearancePressed.Options.UseFont = true;
            this.navItemCustomer.Caption = "Quản lý khách hàng";
            this.navItemCustomer.Name = "navItemCustomer";
            // 
            // navItemOrder
            // 
            this.navItemOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemOrder.Appearance.Options.UseFont = true;
            this.navItemOrder.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemOrder.AppearanceDisabled.Options.UseFont = true;
            this.navItemOrder.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemOrder.AppearanceHotTracked.Options.UseFont = true;
            this.navItemOrder.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemOrder.AppearancePressed.Options.UseFont = true;
            this.navItemOrder.Caption = "Quản lý đặt phòng";
            this.navItemOrder.Name = "navItemOrder";
            // 
            // navItemProduct
            // 
            this.navItemProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemProduct.Appearance.Options.UseFont = true;
            this.navItemProduct.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemProduct.AppearanceDisabled.Options.UseFont = true;
            this.navItemProduct.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemProduct.AppearanceHotTracked.Options.UseFont = true;
            this.navItemProduct.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemProduct.AppearancePressed.Options.UseFont = true;
            this.navItemProduct.Caption = "Quản lý dịch vụ";
            this.navItemProduct.Name = "navItemProduct";
            // 
            // gControl
            // 
            this.gControl.Controls.Add(this.galleryControlClient1);
            this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl.Location = new System.Drawing.Point(0, 0);
            this.gControl.Margin = new System.Windows.Forms.Padding(4);
            this.gControl.Name = "gControl";
            this.barManager1.SetPopupContextMenu(this.gControl, this.popupMenu1);
            this.gControl.Size = new System.Drawing.Size(913, 469);
            this.gControl.TabIndex = 0;
            this.gControl.Text = "galleryControl1";
            this.gControl.DoubleClick += new System.EventHandler(this.gControl_DoubleClick);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.galleryControlClient1.Size = new System.Drawing.Size(892, 465);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "room1.png");
            this.imageList1.Images.SetKeyName(1, "room0.png");
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMakeOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeRoom)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Popup += new System.EventHandler(this.popupMenu1_Popup);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Caption = "Đặt phòng";
            this.btnMakeOrder.Id = 0;
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMakeOrder_ItemClick);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Caption = "Cập nhật";
            this.btnUpdateOrder.Id = 1;
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateOrder_ItemClick);
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.Caption = "Chuyển phòng";
            this.btnChangeRoom.Id = 2;
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeRoom_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnMakeOrder,
            this.btnUpdateOrder,
            this.btnChangeRoom});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1194, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1194, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 529);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1194, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 529);
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 529);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn OU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            this.gControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSystem;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Ribbon.GalleryControl gControl;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnMakeOrder;
        private DevExpress.XtraBars.BarButtonItem btnUpdateOrder;
        private DevExpress.XtraBars.BarButtonItem btnChangeRoom;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraNavBar.NavBarItem navItemTypeRoom;
        private DevExpress.XtraNavBar.NavBarItem navItemFloor;
        private DevExpress.XtraNavBar.NavBarItem navItemRoom;
        private DevExpress.XtraNavBar.NavBarItem navItemEmployee;
        private DevExpress.XtraNavBar.NavBarItem navItemCustomer;
        private DevExpress.XtraNavBar.NavBarItem navItemOrder;
        private DevExpress.XtraNavBar.NavBarItem navItemProduct;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

