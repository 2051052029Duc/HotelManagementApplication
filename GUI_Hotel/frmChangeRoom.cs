using BUS_Hotel;
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
    public partial class frmChangeRoom : DevExpress.XtraEditors.XtraForm
    {
        public int roomId;

        RoomBUS busRoom = new RoomBUS();
        OrderDetailRoomBUS busOdr = new OrderDetailRoomBUS();
        OrderDetailProductBUS busOdp = new OrderDetailProductBUS();
        OrderBUS busOrder = new OrderBUS(); 
        FloorBUS busFloor = new FloorBUS();
        ProductBUS busProduct = new ProductBUS();
        TypeRoomBUS busTypeRoom = new TypeRoomBUS();
        DTO_OrderDetailRoom odr;
        DTO_OrderDetailProduct odp;
        public frmChangeRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (searchRoom.EditValue == null || searchRoom.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn phòng để chuyển!");
                return;
            }
            else
            {
                
                DTO_Room nextRoom = busRoom.getRoomById(int.Parse(searchRoom.EditValue.ToString()));
                DTO_TypeRoom typeRoom = busTypeRoom.getTypeRoomById(nextRoom.Room_type_id);
                float price = typeRoom.TypeRoom_price;

                odr = busOdr.getOdrByIdRoom(roomId);

                DTO_Order order = busOrder.getOrderById(odr.Room_order_id);
                List<DTO_OrderDetailProduct> list = busOdp.getOrderDetailProductsByRoom(roomId, odr.Room_order_id);
                try
                {
                    foreach (var item in list)
                    {
                        item.Product_room_id = int.Parse(searchRoom.EditValue.ToString());
                        busOdp.updateOrderDetailProduct(item);
                        price += (busProduct.getProductById(item.Product_product_id).Product_price * item.Product_quantity);
                    }
                    odr.Room_room_id = nextRoom.Room_id;
                    busOdr.updateOrderDetailRoom(odr);
                    order.Order_total_amount = price;
                    busOrder.updateOrder(order);
                }
                catch
                {
                    MessageBox.Show("Chuyển phòng thất bại!");
                    return;
                }
                busRoom.changeStatusRoomById(roomId, true);
                busRoom.changeStatusRoomById(nextRoom.Room_id, false);

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.showRoom();

                MessageBox.Show("Chuyển phòng thành công!");
           }

        }

        private void frmChangeRoom_Load(object sender, EventArgs e)
        {
            DTO_Room currRoom = busRoom.getRoomById(roomId);
            lbCurrRoom.Text += " " + currRoom.Room_num;
            loadEmptyRoom();

        }

        void loadEmptyRoom()
        {
            searchRoom.Properties.DataSource = busRoom.getEmptyRoom();
            searchRoom.Properties.ValueMember = "Room_id";
            searchRoom.Properties.DisplayMember = "Room_num";
        }
    }
}