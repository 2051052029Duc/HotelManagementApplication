using BUS_Hotel;
using DevExpress.XtraCharts;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace GUI_Hotel
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }
        OrderBUS bus_order = new OrderBUS();
        OrderDetailProductBUS bus_od_product = new OrderDetailProductBUS();
        ProductBUS bus_product = new ProductBUS();
        CustomerBUS bus_cus = new CustomerBUS();
        RoomBUS bus_room = new RoomBUS();

        private void frmReport_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            loadData();
        }
        void loadData()
        {
            List<DTO_Order> lstO = bus_order.getPaidOrders(dtpStart.Value.AddDays(-1), dtpEnd.Value);
            List<DTO_CustomOrder> list = new List<DTO_CustomOrder>();
            string roomNum = "";
            foreach (var item in lstO)
            {
                DTO_CustomOrder o = new DTO_CustomOrder();
                o.Order_id = item.Order_id;
                o.Order_checkin_date = item.Order_checkin_date;
                o.Order_checkout_date = item.Order_checkout_date;
                o.Order_total_amount = item.Order_total_amount;
                o.Order_num_of_cus = item.Order_num_of_cus;
                o.Order_status = item.Order_status;
                o.Order_is_group = item.Order_is_group;
                o.Order_customer_id = item.Order_customer_id;
                o.Order_employee_id = item.Order_employee_id;
                o.Order_name_cus = bus_cus.getCusById(item.Order_customer_id).Customer_name;
                List<DTO_Room> listRoom = bus_room.getRoomByOrderId(item.Order_id);
                foreach (var r in listRoom)
                {
                    roomNum += r.Room_num + " ";
                }
                o.Order_rooms = roomNum;
                list.Add(o);
                roomNum = "";
            }
            gcDanhSach.DataSource = list;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            loadData();

            List<DateTime> dates = new List<DateTime>();
            DateTime currentDate = dtpStart.Value.Date;
            while (currentDate <= dtpEnd.Value.Date)
            {
                // Thêm ngày hiện tại vào danh sách
                dates.Add(currentDate);

                // Tăng ngày hiện tại lên 1 ngày
                currentDate = currentDate.AddDays(1);
            }

            Dictionary<DateTime, double> dailyTotal = new Dictionary<DateTime, double>();
            Dictionary<int, double> weekTotal = new Dictionary<int, double>();
            Dictionary<int, double> monthTotal = new Dictionary<int, double>();

            foreach (DTO_Order order in bus_order.getOrders(dtpStart.Value.AddDays(-1), dtpEnd.Value))
            {
                DateTime checkoutDate = order.Order_checkout_date.Date;
                DateTime checkinDate = order.Order_checkin_date.Date;
                DateTime From = dtpStart.Value.Date;
                DateTime To = dtpEnd.Value.Date;

                if ((To - From).TotalDays > 7 && (To - From).TotalDays < 28 && order.Order_status == true)
                {
                    int weekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(checkinDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                    if (weekTotal.ContainsKey(weekNumber))
                    {
                        weekTotal[weekNumber] += order.Order_total_amount;
                    }
                    else weekTotal[weekNumber] = order.Order_total_amount;
                } 
                else if ((To - From).TotalDays >= 28 && order.Order_status == true)
                {
                    int monthNumer = checkoutDate.Month;
                    if (monthTotal.ContainsKey(monthNumer))
                    {
                        monthTotal[monthNumer] += order.Order_total_amount;
                    }
                    else monthTotal[monthNumer] = order.Order_total_amount;
                } 
                else if ((To - From).TotalDays >= 28 && (To.Year != From.Year) )
                {
                    MessageBox.Show("Vui lòng chọn ngày checkin và ngày checkout cùng năm");
                } else if (order.Order_status == true)
                {
                    if (dailyTotal.ContainsKey(checkoutDate))
                    {
                        dailyTotal[checkoutDate] += order.Order_total_amount;
                    }
                    else dailyTotal[checkoutDate] = order.Order_total_amount;
                }

            }

            chart1.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Total Amount");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);

            // Truyền dữ liệu vào biểu đồ           
            if (monthTotal.Count > 0)
            {
                foreach (int monthNumber in monthTotal.Keys)
                {
                    double totalAmount = monthTotal[monthNumber];
                    series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber), totalAmount);
                }

            } else if (weekTotal.Count > 0)
            {
                int count = 1;
                foreach (int weekNumber in weekTotal.Keys)
                {
                    count++;
                    double totalAmount = weekTotal[weekNumber];
                    series.Points.AddXY("week " + count, totalAmount);
                }
            } else
            {
                foreach (DateTime date in dailyTotal.Keys)
                {
                    double totalAmount = dailyTotal[date];
                    series.Points.AddXY(date, totalAmount);
                }
            }
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save chart image";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                chart1.SaveImage(path, ChartImageFormat.Png);
            }
        }
        string id = null;
        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Font font = new Font("Microsoft YaHei UI", 16);
            try
            {
                id = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Order_id").ToString();
            } catch
            {
                id = "-1";
            }
            //try
            //{
            //    var order_id = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Order_id");
            //    if (order_id != null)
            //    {
            //        id = order_id.ToString();
            //    }
            //    else
            //    {
            //        id = "-1";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Xử lý ngoại lệ nếu cần
            //}
            //if(id == null)
            //{
            //    id = "-1";
            //}
            List<ProductCart> cart = new List<ProductCart>();
            foreach (var item in bus_od_product.getOrderDetailProductsByOrderId(int.Parse(id)))
            {
                ProductCart c = new ProductCart();
                c.productName = bus_product.getProductById(item.Product_product_id).Product_name;
                c.productQty = item.Product_quantity;      
                cart.Add(c);
            }

            chart2.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Series2");
            series.ChartType = SeriesChartType.Pie;
            chart2.Series.Add(series);
            foreach (ProductCart c in cart)
            {
                DataPoint point = new DataPoint();
                point.SetValueY(c.productQty);
                point.AxisLabel = c.productQty.ToString();
                point.LabelForeColor = System.Drawing.Color.White;
                point.LegendText = c.productName.ToString();
                point.CustomProperties = "PieLabelStyle=Inside, PieLineColor=Black";
                chart2.Series["Series2"].Points.Add(point);
                
            }
        }
    }
}