using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using DAL_Hotel;
using BUS_Hotel;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraEditors.Filtering;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraVerticalGrid;

namespace GUI_Hotel
{
    
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        GridHitInfo downhitInfo = null; //Lưu 1 dòng khi nhấp chuột
        DTO_Customer customer = new DTO_Customer();
        int idPhong = 0, idOrder = 0;
        string soPhong;
        bool checkAdd = false;
        bool checkView = false;
        bool checkEdit = false;

        RoomBUS bus_room = new RoomBUS();
        CustomerBUS bus_customer = new CustomerBUS();
        ProductBUS bus_product = new ProductBUS();
        OrderBUS bus_order = new OrderBUS();
        OrderDetailProductBUS bus_od_product = new OrderDetailProductBUS();
        OrderDetailRoomBUS bus_od_room = new OrderDetailRoomBUS();
        CustomerBUS bus_cus = new CustomerBUS();

        List<ProductCart> listProductCart;

        public frmOrder()
        {
            InitializeComponent();
            string sql = "SELECT r.id, r.num, f.id, f.name, tr.price FROM Room r, TypeRoom tr, Floor f WHERE r.floorId = f.id AND r.typeRoomId = tr.id AND r.status=1";
            DataTable tb = Functions.getData(sql);
            gcPhong.DataSource = tb;
            gcPhongDat.DataSource = tb.Clone();
            gvPhong.OptionsBehavior.Editable = false;
            gvPhong.ExpandAllGroups();
            gvPhongDat.OptionsBehavior.Editable = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            checkAdd = true;
            tabDanhSach.SelectedTabPage = pageOrderDetails;
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idOrder == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                checkEdit = true;
                btnSave.Enabled = checkEdit;
                tabDanhSach.SelectedTabPage = pageOrderDetails;

                loadOrder();

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idOrder == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
                reset();
                loadOrder();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkAdd)
            {
                DateTime checkinDate = dpCheckin.Value;
                DateTime checkoutDate = dpCheckout.Value;
                float totalAmount = float.Parse(txtTotalAmount.Text);
                int numCus = int.Parse(txtNumCus.Text);
                bool status = Convert.ToBoolean(cbStatus.SelectedValue.ToString());
                bool isGroup = chkIsGroup.Checked;
                string note = txtNote.Text;
                int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                int employeeId = Form1.employee.Employee_id;


                try
                {
                    DTO_Order order = new DTO_Order(checkinDate, checkoutDate, totalAmount, numCus, status, isGroup, note, customerId, employeeId);

                    int order_id = bus_order.addOrder(order);
                    int quantity, roomId, prodId;
                    int roomDetailDayAt, roomDetailRoomId, roomDetailOrderId;


                    for (int i = 0; i < gvPhongDat.RowCount; i++)
                    {
                        DataRow row = gvPhongDat.GetDataRow(i);
                        if (row != null)
                        {
                            roomDetailDayAt = Functions.getDayAt(checkinDate, checkoutDate);
                            roomDetailRoomId = int.Parse(row["id"].ToString());
                            roomDetailOrderId = order_id;

                            DTO_OrderDetailRoom odr = new DTO_OrderDetailRoom(roomDetailDayAt, roomDetailRoomId, roomDetailOrderId);
                            bus_od_room.addOrderDetailRoom(odr);
                            bus_room.changeStatusRoomById(roomDetailRoomId, false);

                            Form1 form1 = (Form1)Application.OpenForms["Form1"];
                            form1.showRoom();
                        }
                    }

                    for (int j = 0; j < gvSanPhamDat.RowCount; j++)
                    {
                        ProductCart c = (ProductCart)gvSanPhamDat.GetRow(j);
                        quantity = c.productQty;
                        roomId = c.roomId;
                        prodId = c.productId;
                        DTO_OrderDetailProduct od = new DTO_OrderDetailProduct(quantity, roomId, order_id, prodId);
                        bus_od_product.addOrderDetailProduct(od);

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    checkAdd = false;
                }
                tabDanhSach.SelectedTabPage = pageOrders;
                loadOrder();
                reset();
                string sql = "SELECT r.id, r.num, f.id, f.name, tr.price FROM Room r, TypeRoom tr, Floor f WHERE r.floorId = f.id AND r.typeRoomId = tr.id AND r.status=1";
                DataTable tb = Functions.getData(sql);
                gcPhong.DataSource = tb;
                gvPhong.ExpandAllGroups();

                MessageBox.Show("Thêm đơn đặt phòng thành công!");
            }
            else if(!checkAdd && checkEdit)
            {
                try
                {
                    DateTime checkinDate = dpCheckin.Value;
                    DateTime checkoutDate = dpCheckout.Value;
                    float totalAmount = float.Parse(txtTotalAmount.Text);
                    int numCus = int.Parse(txtNumCus.Text);
                    bool status = Convert.ToBoolean(cbStatus.SelectedValue.ToString());
                    bool isGroup = chkIsGroup.Checked;
                    string note = txtNote.Text;
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    int employeeId = Form1.employee.Employee_id;
                    

                    DTO_Order order = new DTO_Order(idOrder, checkinDate, checkoutDate, totalAmount, numCus, status, isGroup, note, customerId, employeeId);

                    bus_order.updateOrder(order);
                    bus_od_product.deleteOrderDetailProductsByOrderId(idOrder);
                    bus_od_room.deleteOrderDetailRoomsByOrderId(idOrder);
                    int quantity, roomId, prodId;
                    int roomDetailDayAt, roomDetailRoomId, roomDetailOrderId;


                    for (int i = 0; i < gvPhongDat.RowCount; i++)
                    {
                        DataRow row = gvPhongDat.GetDataRow(i);
                        if (row != null)
                        {
                            roomDetailDayAt = Functions.getDayAt(checkinDate, checkoutDate);
                            roomDetailRoomId = int.Parse(row["id"].ToString());
                            roomDetailOrderId = idOrder;

                            DTO_OrderDetailRoom odr = new DTO_OrderDetailRoom(roomDetailDayAt, roomDetailRoomId, roomDetailOrderId);
                            bus_od_room.addOrderDetailRoom(odr);

                            if ((bool)cbStatus.SelectedValue)
                            {
                                bus_room.changeStatusRoomById(roomDetailRoomId, true);
                            }
                            else bus_room.changeStatusRoomById(roomDetailRoomId, false);


                            Form1 form1 = (Form1)Application.OpenForms["Form1"];
                            form1.showRoom();
                            
                        }
                    }

                    for (int j = 0; j < gvSanPhamDat.RowCount; j++)
                    {
                        ProductCart c = (ProductCart)gvSanPhamDat.GetRow(j);
                        quantity = c.productQty;
                        roomId = c.roomId;
                        prodId = c.productId;
                        DTO_OrderDetailProduct od = new DTO_OrderDetailProduct(quantity, roomId, idOrder, prodId);
                        bus_od_product.addOrderDetailProduct(od);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    checkEdit = false;
                }

                tabDanhSach.SelectedTabPage = pageOrders;
                loadOrder();
                reset();

                string sql = "SELECT r.id, r.num, f.id, f.name, tr.price FROM Room r, TypeRoom tr, Floor f WHERE r.floorId = f.id AND r.typeRoomId = tr.id AND r.status=1";
                DataTable tb = Functions.getData(sql);
                gcPhong.DataSource = tb;
                gvPhong.ExpandAllGroups();

                MessageBox.Show("Sửa đơn đặt phòng thành công!");
            }

            

        }

        void reset()
        {
            dpCheckin.Value = DateTime.Now;
            dpCheckout.Value = DateTime.Now.AddDays(1);
            txtNumCus.Text = "1";
            chkIsGroup.Checked = true;
            cbStatus.SelectedValue = false;
            txtNote.Text = "";
            txtTotalAmount.Text = "0";

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            reset();
            dpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dpTo.Value = DateTime.Now;
            loadCbCus();
            loadGcProduct();
            cbStatus.DataSource = OrderStatus.getList();
            cbStatus.DisplayMember = "name";
            cbStatus.ValueMember = "value";
            listProductCart = new List<ProductCart>();
            loadOrder();
        }

        public void loadCbCus()
        {
            cbCustomer.DataSource = bus_customer.getCustmer();
            cbCustomer.DisplayMember = "Customer_name";
            cbCustomer.ValueMember = "Customer_id";
        }

        void loadGcProduct()
        {
            gcSanPham.DataSource = bus_product.getProducts();
            gvSanPham.OptionsBehavior.Editable = false;
        }

        private void gvPhongDat_MouseDown(object sender, MouseEventArgs e) // Xử lý kéo thả giữa 2 luói dữ liệu
        {
            if (gvPhongDat.GetFocusedRowCellValue("id") != null)
            {
                idPhong = int.Parse(gvPhongDat.GetFocusedRowCellValue("id").ToString());
                soPhong = gvPhongDat.GetFocusedRowCellValue("num").ToString();
            }
            GridView view = sender as GridView;
            downhitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0) 
            {
                downhitInfo = hitInfo;
            }
        }

        private void gvPhongDat_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downhitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downhitInfo.HitPoint.X - dragSize.Width / 2, downhitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downhitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downhitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downhitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downhitInfo.HitPoint.X - dragSize.Width / 2, downhitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downhitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downhitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            } 
        }

        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downhitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0) 
            {
                downhitInfo = hitInfo;
            }
        }

        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable tb = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData (typeof(DataRow)) as DataRow; 
            if (row != null && tb != null && row.Table != tb) 
            {
                tb.ImportRow(row);
                row.Delete();
            }
        }

        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
                e.Effect = DragDropEffects.Move;
            else e.Effect =  DragDropEffects.None;
        }

        private void gcSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                return;               
            }
            if (gvSanPham.GetFocusedRowCellValue("Product_id") != null)
            {
                ProductCart item = new ProductCart();
                item.productId = int.Parse(gvSanPham.GetFocusedRowCellValue("Product_id").ToString());
                item.productName = gvSanPham.GetFocusedRowCellValue("Product_name").ToString();
                item.roomId = idPhong;
                item.roomNum = soPhong;
                item.productPrice = float.Parse(gvSanPham.GetFocusedRowCellValue("Product_price").ToString());
                item.productQty = 1;
                item.productTotalAmount = item.productPrice * item.productQty;
                foreach(var p in listProductCart)
                {
                    if (p.productId == item.productId && p.roomNum == item.roomNum)
                    {
                        p.productQty += 1;
                        p.productTotalAmount = p.productPrice * p.productQty;
                        loadProductOrder();
                        txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + float.Parse(gvPhongDat.Columns["price"].SummaryItem.SummaryValue.ToString())).ToString("N0");
                        gvSanPhamDat.UpdateTotalSummary();
                        gcSanPhamDat.DataSource = listProductCart;
                        return;
                    }
                }
                listProductCart.Add(item);
            }
            loadProductOrder();
            gvSanPhamDat.UpdateTotalSummary();
            txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + float.Parse(gvPhongDat.Columns["price"].SummaryItem.SummaryValue.ToString())).ToString("N0");
            gcSanPhamDat.DataSource = listProductCart;
        }

        void loadProductOrder()
        {
            List<ProductCart> listReload = new List<ProductCart>();
            foreach(var item in listProductCart)
            {
                listReload.Add(item);
            }
            gcSanPhamDat.DataSource = listReload;
        }

        private void gvSanPhamDat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "productQty")
            {
                int quantity = int.Parse(e.Value.ToString());
                if (quantity != 0)
                {
                    double amount = double.Parse(gvSanPhamDat.GetRowCellValue(gvSanPhamDat.FocusedRowHandle, "productPrice").ToString());
                    gvSanPhamDat.SetRowCellValue(gvSanPhamDat.FocusedRowHandle, "productTotalAmount", quantity * amount);

                }
                else gvSanPhamDat.SetRowCellValue(gvSanPham.FocusedRowHandle, "productTotalAmount", 0);
            }
            gvSanPhamDat.UpdateTotalSummary();
            txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + float.Parse(gvPhongDat.Columns["price"].SummaryItem.SummaryValue.ToString())).ToString("N0");

        }

        private void gvPhongDat_RowCountChanged(object sender, EventArgs e)
        {
            double t = 0;
            if (gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue == null)
            {
                t = 0;
            }
            else t = float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString());
            txtTotalAmount.Text = (double.Parse(gvPhongDat.Columns["price"].SummaryItem.SummaryValue.ToString()) + t).ToString("N0");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmC = new frmCustomer();
            frmC.ShowDialog(); ;
        }

        public void setCustomer(int idCus)
        {
            var cus = bus_customer.getCusById(idCus);
            cbCustomer.SelectedValue = cus.Customer_id;
            cbCustomer.Text = cus.Customer_name;
        }

        private void loadOrder()
        {
            List<DTO_CustomOrder> list = new List<DTO_CustomOrder>();
            List<DTO_Order> lstO = bus_order.getOrders(dpFrom.Value, dpTo.Value.AddDays(1));
            string roomNum = "";
            foreach (var item in lstO) {
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

        private void loadOrderDetailProduct()
        {
            List<ProductCart> cart = new List<ProductCart>();
            foreach (var item in bus_od_product.getOrderDetailProductsByOrderId(idOrder))
            {
                ProductCart c = new ProductCart();
                c.roomNum = bus_room.getRoomById(item.Product_room_id).Room_num;
                c.roomId = item.Product_room_id;
                c.productId = item.Product_product_id;
                c.productName = bus_product.getProductById(item.Product_product_id).Product_name;
                c.productQty = item.Product_quantity;
                c.productPrice = bus_product.getProductById(item.Product_product_id).Product_price;
                c.productTotalAmount = c.productQty * c.productPrice;
                cart.Add(c);
            }
            gcSanPhamDat.DataSource = cart;
        }

        private void loadOrderDetailRoom()
        {
            DataTable tb = Functions.getTbOrderDetailRoom(idOrder);
            gcPhongDat.DataSource = tb;
        }


        private void tabDanhSach_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (tabDanhSach.SelectedTabPage == pageOrders)
            {
                if (idOrder != 0 || checkView == true || checkAdd == true || checkEdit == true)
                {
                    btnSave.Enabled = checkAdd || checkEdit;
                    e.Cancel = false;

                    DTO_Order o = bus_order.getOrderById(idOrder);
                    if (o != null)
                    {
                        dpCheckin.Value = o.Order_checkin_date;
                        dpCheckout.Value = o.Order_checkout_date;
                        txtNumCus.Text = o.Order_num_of_cus.ToString();
                        cbStatus.SelectedValue = o.Order_status;
                        chkIsGroup.Checked = o.Order_is_group;
                        txtNote.Text = o.Order_note;
                        DTO_Customer cus = bus_customer.getCusById(o.Order_customer_id);
                        cbCustomer.SelectedValue = cus.Customer_id;
                    }
                    

                    loadOrderDetailProduct();
                    loadOrderDetailRoom();
                    checkView = false;
                }
                else
                {
                    btnSave.Enabled = true;

                    //foreach (var item in bus_od_product.getOrderDetailProductsByOrderId(idOrder))
                    //{
                    //    listOrderDetailProduct.Add(item);
                    //}
                    //MessageBox.Show(gcSanPhamDat.DataSource.ToString());
                    MessageBox.Show("Vui lòng chọn đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;

                }
            }
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void gcSanPhamDat_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvDanhSach.GetFocusedRowCellValue("Order_id") != null)
                idOrder = int.Parse(gvDanhSach.GetFocusedRowCellValue("Order_id").ToString());

  

        }
    }
}