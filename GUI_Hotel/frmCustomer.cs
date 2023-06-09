using BUS_Hotel;
using DevExpress.XtraEditors;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hotel
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        frmOrder objOrder = (frmOrder) Application.OpenForms["frmOrder"]; // truy cập các biến và hàm public từ frmOrder
        frmOrder1 objOrder1 = (frmOrder1)Application.OpenForms["frmOrder1"];

        CustomerBUS busCustomer = new CustomerBUS();

        public string loaiDp;

        void loadData()
        {
            gcDanhSach.DataSource = busCustomer.getCustmer();
        }

        void clearTextBox()
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerAddress.Clear();
            txtCustomerPersonalID.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //Can hoi:
        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string customerId = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_id").ToString();
            string customerName = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_name").ToString();
            string customerGender = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_gender").ToString();
            string customerPhone = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_phone").ToString();
            string customerAddress = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_address").ToString();
            string customerPersonalID = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Customer_personalID").ToString();

            if (customerGender == "True")
            {
                rdNam.Checked = true;
            }
            else
                rdNu.Checked = true;
            txtCustomerName.Text = customerId;
            txtCustomerName.Text = customerName;
            txtCustomerPhone.Text = customerPhone;
            txtCustomerAddress.Text = customerAddress;
            txtCustomerPersonalID.Text = customerPersonalID;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() != "" && txtCustomerPhone.Text.Trim() != "" && txtCustomerAddress.Text.Trim() != "" && txtCustomerPersonalID.Text.Trim() != "")
            {
                string customerName = txtCustomerName.Text;
                bool customerGender = false;
                if (rdNam.Checked)
                    customerGender = true;

                string customerPhone = txtCustomerPhone.Text;
                string customerAddress = txtCustomerAddress.Text;
                string customerPersonalID = txtCustomerPersonalID.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busCustomer.addCustomer(new DTO_Customer(customerName, customerGender, customerPhone, customerAddress, customerPersonalID)))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else MessageBox.Show("Thêm không thành công!");
                }
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
             
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() != "" && txtCustomerPhone.Text.Trim() != "" && txtCustomerAddress.Text.Trim() != "" && txtCustomerPersonalID.Text.Trim() != "")
            {
                int customerId = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Customer_id").ToString());
                string customerName = txtCustomerName.Text;
                bool customerGender = false;
                if (rdNam.Checked)
                    customerGender = true;

                string customerPhone = txtCustomerPhone.Text;
                string customerAddress = txtCustomerAddress.Text;
                string customerPersonalID = txtCustomerPersonalID.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busCustomer.updateCustomer(new DTO_Customer(customerId, customerName, customerGender, customerPhone, customerAddress, customerPersonalID)))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else MessageBox.Show("Cập nhật không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                //Can hoi
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Customer_id").ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busCustomer.deleteCustomer(id))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Xoá thành công!");
                    }
                    else MessageBox.Show("Xoá không thành công!");
                }
            
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if(gvDanhSach.GetFocusedRowCellValue("Customer_id") != null)
            {
                if (loaiDp == "1")
                {
                    objOrder1.loadCus();
                    objOrder1.setCustomer(int.Parse(gvDanhSach.GetFocusedRowCellValue("Customer_id").ToString()));

                }
                else
                {
                    objOrder.loadCbCus();
                    objOrder.setCustomer(int.Parse(gvDanhSach.GetFocusedRowCellValue("Customer_id").ToString()));
                }

                this.Close();
            }
        }
    }
}