using BUS_Hotel;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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
using static GUI_Hotel.Form1;

namespace GUI_Hotel
{
    public partial class frmRoom : DevExpress.XtraEditors.XtraForm
    {

        public frmRoom()
        {
            InitializeComponent();
        }
        RoomBUS busRoom = new RoomBUS();
        FloorBUS busFloor = new FloorBUS();
        TypeRoomBUS busTypeRoom = new TypeRoomBUS();
        Form1 form1 = (Form1)Application.OpenForms["Form1"];

        private void frmRoom_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataFloor();
            loadDataTypeRoom();
        }

        void loadData()
        {
            gcDanhSach.DataSource = busRoom.getRoom();
        }
        void loadDataFloor()
        {
            /*List<string> dataList = new List<string>();*/
            cbFloor.DataSource = busFloor.getFloor();
            cbFloor.DisplayMember= "Floor_name";
        }

        void loadDataTypeRoom()
        {
            cbTypeRoom.DataSource = busTypeRoom.getTypeRoom();
            cbTypeRoom.DisplayMember = "TypeRoom_name";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != "")
            {
                if (!compareNum())
                {
                    string floorName = cbFloor.SelectedItem.ToString();
                    int floorID = busFloor.getFloorIdByName(floorName);
                    string typeRoomName = cbTypeRoom.SelectedItem.ToString();
                    int typeRoomID = busTypeRoom.getTypeRoomIDByName(typeRoomName);
                    bool status = checkBoxStatus.Checked;
                    DTO_Room room = new DTO_Room(txtNum.Text, status, floorID, typeRoomID);

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busRoom.addRoom(room))
                        {
                            loadData();
                            txtNum.Clear();
                            MessageBox.Show("Thêm thành công.");
                            form1.showRoom();

                        }
                        else MessageBox.Show("Thêm không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng số phòng. Vui lòng kiểm tra lại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != "")
            {          
                string floorName = cbFloor.SelectedItem.ToString();
                int floorID = busFloor.getFloorIdByName(floorName);
                string typeRoomName = cbTypeRoom.SelectedItem.ToString();
                int typeRoomID = busTypeRoom.getTypeRoomIDByName(typeRoomName);
                bool status = checkBoxStatus.Checked;
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Room_id") + "");
                DTO_Room room = new DTO_Room(txtNum.Text, status, floorID, typeRoomID);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật thông tin phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busRoom.updateRoom(room, id))
                    {
                        loadData();
                        txtNum.Clear();
                        MessageBox.Show("Cập nhật thành công.");
                        form1.showRoom();
                    }
                    else MessageBox.Show("Cập nhật không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Room_id") + "");                  
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (busRoom.removeRoom(id))
                {
                    loadData();
                    txtNum.Clear();
                    MessageBox.Show("Xoá thành công.");
                    form1.showRoom();
                }
                else MessageBox.Show("Xoá không thành công.");
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

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        private void cbTypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        bool compareNum()
        {
            string num = txtNum.Text.Trim();
            for (int i = 0; i < gvDanhSach.DataRowCount; i++)
            {
                string cellValue = gvDanhSach.GetRowCellValue(i, "Room_num").ToString();
                if (cellValue.Contains(num))
                {
                    return true;
                }
            }
            return false;
        }
        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string roomNum = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Room_num").ToString();
            bool roomStatus = Convert.ToBoolean(gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Room_status"));
            int roomOrderId = Convert.ToInt32(gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Room_order_id"));
            int roomFloorId = Convert.ToInt32(gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Room_floor_id"));
            int roomTypeId = Convert.ToInt32(gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Room_type_id"));

            txtNum.Text = roomNum;
            checkBoxStatus.Checked = roomStatus;
            cbFloor.SelectedIndex = cbFloor.FindString(busFloor.getNameFloorByID(roomFloorId));
            cbTypeRoom.SelectedIndex = cbTypeRoom.FindString(busTypeRoom.getTypeRoomName(roomTypeId));
        }
        private void gcDanhSach_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }
    }
}