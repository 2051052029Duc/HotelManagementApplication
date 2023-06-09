using BUS_Hotel;
using DAL_Hotel;
using DevExpress.XtraEditors;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hotel
{
    public partial class frmOrder1 : DevExpress.XtraEditors.XtraForm
    {
        public frmOrder1()
        {
            InitializeComponent();
        }
        public bool isAdd;
        public int idPhong;
        public int idOrder;
        DTO_Room currRoom = new DTO_Room();
        RoomBUS busRoom = new RoomBUS();
        CustomerBUS busCustomer = new CustomerBUS();
        ProductBUS busProduct = new ProductBUS();
        OrderBUS busOrder = new OrderBUS();
        TypeRoomBUS busTypeRoom = new TypeRoomBUS();
        OrderDetailRoomBUS busOdr = new OrderDetailRoomBUS();
        OrderDetailProductBUS busOdp = new OrderDetailProductBUS();
        DTO_Customer cus = new DTO_Customer();
        DTO_OrderDetailRoom odr;
        float roomPrice = 0;

        List<ProductCart> listProductCart;


        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmOrder1_Load(object sender, EventArgs e)
        {
            
            currRoom = busRoom.getRoomById(idPhong);
            lbRoomNum.Text += " " + currRoom.Room_num;
            loadCus();
            roomPrice = busTypeRoom.getTypeRoomById(currRoom.Room_type_id).TypeRoom_price;
            dpCheckin.Value = DateTime.Now;
            dpCheckout.Value = DateTime.Now.AddDays(1);

            cbStatus.DataSource = OrderStatus.getList();
            cbStatus.DisplayMember = "name";
            cbStatus.ValueMember = "value";
            txtNumCus.Text = "1";
            searchCus.EditValue = 1;
            txtTotalAmount.Text = roomPrice.ToString("N0");
            loadGcProduct();
            listProductCart = new List<ProductCart>();

            if (!isAdd)
            {
                odr = busOdr.getOdrByIdRoom(idPhong);
                DTO_Order o = busOrder.getOrderById(odr.Room_order_id);

                dpCheckin.Value = o.Order_checkin_date;
                dpCheckout.Value = o.Order_checkout_date;
                cbStatus.SelectedValue = o.Order_status;
                txtNumCus.Text = o.Order_num_of_cus.ToString();
                searchCus.EditValue = o.Order_customer_id;
                txtNote.Text = o.Order_note;
                idOrder = odr.Room_order_id;
                loadOrderDetailProduct();
                txtTotalAmount.Text = o.Order_total_amount.ToString("N0");

            }
        }
        public void loadCus()
        {
            searchCus.Properties.DataSource = busCustomer.getCustmer();
            searchCus.Properties.ValueMember = "Customer_id";
            searchCus.Properties.DisplayMember = "Customer_name";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer();
            f.loaiDp = "1";
            f.ShowDialog();
        }

        public void setCustomer(int idCus)
        {
            searchCus.EditValue = idCus;
        }

        void loadGcProduct()
        {
            gcSanPham.DataSource = busProduct.getProducts();
            gvSanPham.OptionsBehavior.Editable = false;
        }

        private void gvSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSanPham.GetFocusedRowCellValue("Product_id") != null)
            {
                ProductCart item = new ProductCart();
                item.productId = int.Parse(gvSanPham.GetFocusedRowCellValue("Product_id").ToString());
                item.productName = gvSanPham.GetFocusedRowCellValue("Product_name").ToString();
                item.roomId = idPhong;
                item.roomNum = currRoom.Room_num;
                item.productPrice = float.Parse(gvSanPham.GetFocusedRowCellValue("Product_price").ToString());
                item.productQty = 1;
                item.productTotalAmount = item.productPrice * item.productQty;
                foreach (var p in listProductCart)
                {
                    if (p.productId == item.productId && p.roomNum == item.roomNum)
                    {
                        p.productQty += 1;
                        p.productTotalAmount = p.productPrice * p.productQty;
                        loadProductOrder();
                        txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + roomPrice).ToString("N0");
                        gvSanPhamDat.UpdateTotalSummary();
                        gcSanPhamDat.DataSource = listProductCart;
                        return;
                    }
                }
                listProductCart.Add(item);
            }
            loadProductOrder();
            gvSanPhamDat.UpdateTotalSummary();
            txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + roomPrice).ToString("N0");
            gcSanPhamDat.DataSource = listProductCart;
        }

        void loadProductOrder()
        {
            List<ProductCart> listReload = new List<ProductCart>();
            foreach (var item in listProductCart)
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
            txtTotalAmount.Text = (float.Parse(gvSanPhamDat.Columns["productTotalAmount"].SummaryItem.SummaryValue.ToString()) + roomPrice).ToString("N0");
        }

        private void gvSanPhamDat_HiddenEditor(object sender, EventArgs e)
        {
            gvSanPhamDat.UpdateCurrentRow(); 
        }
        Form1 f1 = new Form1();
        private void btnSave_Click(object sender, EventArgs e)
        {
            f1.showRoom();
            if (isAdd)
            {
                if (searchCus.EditValue == null || searchCus.EditValue.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!");
                    return;
                }

                DateTime checkinDate = dpCheckin.Value;
                DateTime checkoutDate = dpCheckout.Value;
                float totalAmount = float.Parse(txtTotalAmount.Text);
                int numCus = int.Parse(txtNumCus.Text);
                bool status = Convert.ToBoolean(cbStatus.SelectedValue.ToString());
                string note = txtNote.Text;
                int customerId = int.Parse(searchCus.EditValue.ToString());
                int employeeId = Form1.employee.Employee_id;

                try
                {
                    DTO_Order order = new DTO_Order(checkinDate, checkoutDate, totalAmount, numCus, status, false, note, customerId, employeeId);

                    int order_id = busOrder.addOrder(order);
                    int quantity, roomId, prodId;
                    int roomDetailDayAt, roomDetailRoomId, roomDetailOrderId;

                    roomDetailDayAt = Functions.getDayAt(checkinDate, checkoutDate);
                    roomDetailRoomId = currRoom.Room_id;
                    roomDetailOrderId = order_id;

                    DTO_OrderDetailRoom odr = new DTO_OrderDetailRoom(roomDetailDayAt, roomDetailRoomId, roomDetailOrderId);
                    busOdr.addOrderDetailRoom(odr);
                    busRoom.changeStatusRoomById(roomDetailRoomId, false);

                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    form1.showRoom();

                    for (int j = 0; j < gvSanPhamDat.RowCount; j++)
                    {
                        ProductCart c = (ProductCart)gvSanPhamDat.GetRow(j);
                        quantity = c.productQty;
                        roomId = c.roomId;
                        prodId = c.productId;
                        DTO_OrderDetailProduct od = new DTO_OrderDetailProduct(quantity, roomId, order_id, prodId);
                        busOdp.addOrderDetailProduct(od);
                    }
                    MessageBox.Show("Thêm đơn đặt phòng thành công!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            else
            {
                try
                {
                    DateTime checkinDate = dpCheckin.Value;
                    DateTime checkoutDate = dpCheckout.Value;
                    float totalAmount = float.Parse(txtTotalAmount.Text);
                    int numCus = int.Parse(txtNumCus.Text);
                    bool status = Convert.ToBoolean(cbStatus.SelectedValue.ToString());
                    string note = txtNote.Text;
                    int customerId = int.Parse(searchCus.EditValue.ToString());
                    int employeeId = Form1.employee.Employee_id;


                    DTO_Order order = new DTO_Order(idOrder, checkinDate, checkoutDate, totalAmount, numCus, status, false, note, customerId, employeeId);

                    busOrder.updateOrder(order);
                    busOdp.deleteOrderDetailProductsByOrderId(idOrder);
                    busOdr.deleteOrderDetailRoomsByOrderId(idOrder);
                    int quantity, roomId, prodId;
                    int roomDetailDayAt, roomDetailRoomId, roomDetailOrderId;

                    roomDetailDayAt = Functions.getDayAt(checkinDate, checkoutDate);
                    roomDetailRoomId = currRoom.Room_id;
                    roomDetailOrderId = idOrder;

                    DTO_OrderDetailRoom odr = new DTO_OrderDetailRoom(roomDetailDayAt, roomDetailRoomId, roomDetailOrderId);
                    busOdr.addOrderDetailRoom(odr);
                    busRoom.changeStatusRoomById(roomDetailRoomId, false);

                    if ((bool)cbStatus.SelectedValue)
                    {
                        busRoom.changeStatusRoomById(roomDetailRoomId, true);
                    }
                    else busRoom.changeStatusRoomById(roomDetailRoomId, false);

                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    form1.showRoom();

                    for (int j = 0; j < gvSanPhamDat.RowCount; j++)
                    {
                        ProductCart c = (ProductCart)gvSanPhamDat.GetRow(j);
                        quantity = c.productQty;
                        roomId = c.roomId;
                        prodId = c.productId;
                        DTO_OrderDetailProduct od = new DTO_OrderDetailProduct(quantity, roomId, idOrder, prodId);
                        busOdp.addOrderDetailProduct(od);

                    }
                    MessageBox.Show("Cập nhật đơn đặt phòng thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void loadOrderDetailProduct()
        {
            List<ProductCart> cart = new List<ProductCart>();
            foreach (var item in busOdp.getOrderDetailProductsByOrderId(odr.Room_order_id))
            {
                ProductCart c = new ProductCart();
                c.roomNum = busRoom.getRoomById(item.Product_room_id).Room_num;
                c.roomId = item.Product_room_id;
                c.productId = item.Product_product_id;
                c.productName = busProduct.getProductById(item.Product_product_id).Product_name;
                c.productQty = item.Product_quantity;
                c.productPrice = busProduct.getProductById(item.Product_product_id).Product_price;
                c.productTotalAmount = c.productQty * c.productPrice;
                cart.Add(c);
            }
            gcSanPhamDat.DataSource = cart;
        }

    }
}