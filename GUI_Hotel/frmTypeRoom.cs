using BUS_Hotel;
using DAL_Hotel;
using DevExpress.Utils.Gesture;
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
    public partial class frmTypeRoom : DevExpress.XtraEditors.XtraForm
    {
        TypeRoomBUS busTypeRoom = new TypeRoomBUS();
        public frmTypeRoom()
        {
            InitializeComponent();
        }


        private void frmTypeRoom_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void loadData()
        {
            gcDanhSach.DataSource = busTypeRoom.getTypeRoom();
            
        }
        bool compareName()
        {
            string trName = txtTypeRoomName.Text.Trim();
            for(int i = 0; i < gvDanhSach.DataRowCount; i++)
            {
                string cellValue = gvDanhSach.GetRowCellValue(i, "TypeRoom_name").ToString();
                if (cellValue.Contains(trName))
                {
                    return true;
                }
            }    
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "TypeRoom_id") + "");
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận thêm loại phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (busTypeRoom.deleteTypeRoom(id))
                {
                    loadData();
                    MessageBox.Show("xoá thành công");
                    txtTypeRoomName.Clear();
                    txtTypeRoomePrice.Clear();
                    txtTypeRoomMaxCus.Clear();
                    txtTypeRoomSurCharge.Clear();
                    txtTypeRoomQtyBed.Clear();
                    txtTypeRoomName.Focus();
                }
                else MessageBox.Show("xoá không thành công");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTypeRoomName.Text.Trim() != "" && txtTypeRoomePrice.Text.Trim() != "" && txtTypeRoomMaxCus.Text.Trim() != "" && txtTypeRoomSurCharge.Text.Trim() != "" && txtTypeRoomQtyBed.Text.Trim() != "")
            {
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "TypeRoom_id") + "");
                if (float.Parse(txtTypeRoomePrice.Text) >= float.Parse(txtTypeRoomSurCharge.Text))
                {
                    DTO_TypeRoom tr = new DTO_TypeRoom(
                                   txtTypeRoomName.Text,
                                   float.Parse(txtTypeRoomePrice.Text),
                                   int.Parse(txtTypeRoomMaxCus.Text),
                                   float.Parse(txtTypeRoomSurCharge.Text),
                                   int.Parse(txtTypeRoomQtyBed.Text)
                                   );
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin không?", "Xác nhận thêm loại phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busTypeRoom.updateTypeRoom(tr, id))
                        {
                            loadData();
                            MessageBox.Show("Cập nhật thành công");
                            txtTypeRoomName.Clear();
                            txtTypeRoomePrice.Clear();
                            txtTypeRoomMaxCus.Clear();
                            txtTypeRoomSurCharge.Clear();
                            txtTypeRoomQtyBed.Clear();
                            txtTypeRoomName.Focus();
                        }
                        else MessageBox.Show("Cập nhật không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Chi phí phụ thu được nhập lớn hơn giá. Vui lòng kiểm tra lại");
                } 
                    
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTypeRoomName.Text.Trim() != "" && txtTypeRoomePrice.Text.Trim() != "" && txtTypeRoomMaxCus.Text.Trim() != "" && txtTypeRoomSurCharge.Text.Trim() != "" && txtTypeRoomQtyBed.Text.Trim() != "")
            {
                if (!compareName())
                {
                    if (float.Parse(txtTypeRoomePrice.Text) >= float.Parse(txtTypeRoomSurCharge.Text))
                    {
                        DTO_TypeRoom tr = new DTO_TypeRoom(
                            txtTypeRoomName.Text,
                            float.Parse(txtTypeRoomePrice.Text),
                            int.Parse(txtTypeRoomMaxCus.Text),
                            float.Parse(txtTypeRoomSurCharge.Text),
                            int.Parse(txtTypeRoomQtyBed.Text)
                            );
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm loại phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (busTypeRoom.addTypeRoom(tr))
                            {
                                loadData();
                                MessageBox.Show("Thêm thành công.");
                                txtTypeRoomName.Clear();
                                txtTypeRoomePrice.Clear();
                                txtTypeRoomMaxCus.Clear();
                                txtTypeRoomSurCharge.Clear();
                                txtTypeRoomQtyBed.Clear();
                                txtTypeRoomName.Focus();
                            }
                            else MessageBox.Show("Thêm không thành công.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chi phí phụ thu được nhập lớn hơn giá. Vui lòng kiểm tra lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng tên loại phòng.");

                }
                
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
           
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {


        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            /*MessageBox.Show((gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "TypeRoom_id") + "").ToString());*/
            string tenLoaiPhong = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "TypeRoom_name").ToString();
            string GiaLoaiPhong = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "TypeRoom_price").ToString();
            string SoluongToiDa = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "TypeRoom_maxCus").ToString();
            string ChiPhiPhuThu = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "TypeRoom_surCharge").ToString();
            string SoLuongGiuong = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "TypeRoom_qtyBed").ToString();

            txtTypeRoomName.Text = tenLoaiPhong.ToString();
            txtTypeRoomePrice.Text = GiaLoaiPhong.ToString();
            txtTypeRoomMaxCus.Text = SoluongToiDa.ToString();
            txtTypeRoomSurCharge.Text = ChiPhiPhuThu.ToString();
            txtTypeRoomQtyBed.Text = SoLuongGiuong.ToString();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}