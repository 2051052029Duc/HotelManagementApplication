using BUS_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DAL_Hotel;
using DevExpress.XtraBars;
using DTO_Hotel;

namespace GUI_Hotel
{
   
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static DTO_Employee employee;
        GalleryItem item = null;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(DTO_Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        RoomBUS busRoom = new RoomBUS();

        private void navMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string item = e.Link.ItemName;
            switch (item)
            {
                case "navItemTypeRoom":
                    frmTypeRoom frm1 = new frmTypeRoom();
                    frm1.ShowDialog();
                    break;
                case "navItemFloor":
                    frmFloor frm2 = new frmFloor();
                    frm2.ShowDialog();
                    break;
                case "navItemEmployee":
                    frmEmployee frm4 = new frmEmployee();
                    frm4.ShowDialog();
                    break;
                case "navItemCustomer":
                    frmCustomer frm5 = new frmCustomer();
                    frm5.ShowDialog();
                    break;
                case "navItemProduct":
                    frmProduct frm7 = new frmProduct();
                    frm7.ShowDialog();
                    break;
                case "navItemRoom":
                    frmRoom frm3 = new frmRoom();
                    frm3.ShowDialog();
                    break;
                case "navItemOrder":
                    frmOrder frm6 = new frmOrder();
                    frm6.ShowDialog();
                    break;
            }

        }
        private void btnSystem_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                /*Application.Exit();*/
                this.Close();
            }
        }

        FloorBUS busFloor = new FloorBUS();
        RoomBUS roomBUS = new RoomBUS();
        OrderDetailRoomBUS odrBUS = new OrderDetailRoomBUS();
        OrderBUS oBUS = new OrderBUS();
        public void showRoom()
        {
            gControl.Gallery.Groups.Clear();

            var listFloor = busFloor.getFloor();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach (var f in listFloor)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = f.Floor_name;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var listRoom = roomBUS.getRoomByFloor(f.Floor_id);
                foreach (var r in listRoom)
                {
                    var gcItem = new GalleryItem();
                    gcItem.Caption = r.Room_num;
                    gcItem.Value = r.Room_id;
                    if (r.Room_status)
                        gcItem.ImageOptions.Image = imageList1.Images[0];
                    else gcItem.ImageOptions.Image = imageList1.Images[1];
                    galleryItem.Items.Add(gcItem);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            showRoom();
            lbUser.Text = employee.Employee_name;
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                
                item = hitInfo.GalleryItem;
            }    
        }
        private void btnMakeOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idRoom = int.Parse(item.Value.ToString());
            if (busRoom.getRoomById(idRoom).Room_status)
            {
                frmOrder1 f = new frmOrder1();
                f.idPhong = idRoom;
                f.isAdd = true;
                f.ShowDialog();
            }
            else MessageBox.Show("Phòng không khả dụng!");
        }

        private void splitContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idRoom = int.Parse(item.Value.ToString());
            int idOrder = odrBUS.getOdrByIdRoom(idRoom).Room_order_id;
            
            if (!busRoom.getRoomById(idRoom).Room_status)
            {
                if (oBUS.getOrderById(idOrder).Order_is_group == true)
                {
                    MessageBox.Show("Vui lòng vào chức năng quản lý đặt phòng để cập nhật!");
                    return;
                }
                frmOrder1 f = new frmOrder1();
                f.idPhong = idRoom;
                f.isAdd = false;
                f.ShowDialog();
            }
            else MessageBox.Show("Phòng chưa được đặt!");
        }

        private void btnChangeRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int idRoom = int.Parse(item.Value.ToString());
            int idOrder = odrBUS.getOdrByIdRoom(idRoom).Room_order_id;

            if (!busRoom.getRoomById(idRoom).Room_status)
            {
                if (oBUS.getOrderById(idOrder).Order_is_group == true)
                {
                    MessageBox.Show("Chưa hỗ trợ chức năng chuyển phòng cho đặt phòng theo đoàn");
                    return;
                }
                frmChangeRoom f = new frmChangeRoom();
                f.roomId = idRoom;
                f.ShowDialog();
            }
            else MessageBox.Show("Phòng chưa được đặt!");
        }

        private void gControl_DoubleClick(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                GalleryItem item = hitInfo.GalleryItem;
                int idRoom = int.Parse(item.Value.ToString());
                if (busRoom.getRoomById(idRoom).Room_status)
                {
                    frmOrder1 f = new frmOrder1();
                    f.idPhong = idRoom;
                    f.isAdd = true;
                    f.ShowDialog();
                }
                else MessageBox.Show("Phòng không khả dụng!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLogin frmLg = new frmLogin();
            this.Hide();
            frmLg.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }
    }
}
