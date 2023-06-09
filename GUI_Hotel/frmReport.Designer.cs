namespace GUI_Hotel
{
    partial class frmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExport = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Order_rooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1488, 47);
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
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 597);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1488, 256);
            this.gcDanhSach.TabIndex = 4;
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
            this.gvDanhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhSach_FocusedRowChanged);
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
            this.Order_name_cus.VisibleIndex = 6;
            this.Order_name_cus.Width = 87;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(69, 37);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(171, 30);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Value = new System.DateTime(2023, 4, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(307, 37);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(171, 30);
            this.dtpEnd.TabIndex = 7;
            this.dtpEnd.Value = new System.DateTime(2023, 4, 22, 15, 56, 12, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(505, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn thời gian ";
            // 
            // btnStatistical
            // 
            this.btnStatistical.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.Location = new System.Drawing.Point(540, 84);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(132, 46);
            this.btnStatistical.TabIndex = 9;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 153);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Amount";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(955, 437);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Doanh thu";
            this.chart1.Titles.Add(title1);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(679, 84);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(161, 46);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export to image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(976, 153);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(497, 437);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Sản phẩm";
            this.chart2.Titles.Add(title2);
            // 
            // Order_rooms
            // 
            this.Order_rooms.Caption = "Phòng đặt";
            this.Order_rooms.FieldName = "Order_rooms";
            this.Order_rooms.MinWidth = 25;
            this.Order_rooms.Name = "Order_rooms";
            this.Order_rooms.Visible = true;
            this.Order_rooms.VisibleIndex = 7;
            this.Order_rooms.Width = 94;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 853);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bthThoat;
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
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DevExpress.XtraGrid.Columns.GridColumn Order_name_cus;
        private DevExpress.XtraGrid.Columns.GridColumn Order_rooms;
    }
}