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
    public partial class frmFloor : DevExpress.XtraEditors.XtraForm
    {
        FloorBUS busFloor = new FloorBUS();
        public frmFloor()
        {
            InitializeComponent();
        }

        private void frmFloor_Load(object sender, EventArgs e)
        {
            loadData();
            txtFloorName.Clear();
        }
        void loadData()
        {
            gcDanhSach.DataSource = busFloor.getFloor();
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.showRoom();
        }
        bool compareName()
        {
            string fName = txtFloorName.Text.Trim();
            for (int i = 0; i < gvDanhSach.DataRowCount; i++)
            {
                string cellValue = gvDanhSach.GetRowCellValue(i, "Floor_name").ToString();
                if (cellValue.Contains(fName))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtFloorName.Text.Trim() != "")
            {
                if (!compareName())
                {
                        DTO_Floor f = new DTO_Floor(txtFloorName.Text);
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm tầng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (busFloor.addFloor(f))
                            {
                                MessageBox.Show("Thêm thành công");
                                loadData();
                                txtFloorName.Clear();
                                txtFloorName.Focus();
                                
                            }
                            else MessageBox.Show("Thêm không thành công");
                        }
                }
                else
                {
                    MessageBox.Show("Trùng tên tầng");

                }
            }   
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtFloorName.Text.Trim() != "")
            {
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Floor_id") + "");
                if (!compareName())
                {
                    DTO_Floor f = new DTO_Floor(txtFloorName.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận thêm tầng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busFloor.updateFloor(f, id))
                        {
                            MessageBox.Show("Sửa thành công");
                            loadData();
                            
                            txtFloorName.Clear();
                            txtFloorName.Focus();

                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng tên tầng");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Floor_id") + "");
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận thêm tầng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busFloor.removeFloor(id))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadData();
                        txtFloorName.Clear();
                        txtFloorName.Focus();
                    }
                    else MessageBox.Show("Xoá không thành công");
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

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string TenTang = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Floor_name").ToString();
            txtFloorName.Text = TenTang.ToString();
        }
    }
}