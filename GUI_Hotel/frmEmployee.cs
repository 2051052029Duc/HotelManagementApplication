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
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        EmployeeBUS busEmployee = new EmployeeBUS();

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            gcDanhSach.DataSource = busEmployee.getEmployee();
        }

        void clearTextBox()
        {
            txtEmployeeName.Clear();
            txtEmployeeEmail.Clear();
            txtEmployeePhone.Clear();
            rdNam.Checked= false;
            rdNu.Checked=false;
            txtEmloyeePassword.Clear();
            txtEmloyeeUserName.Clear(); 
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string employeeId = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_id").ToString();
            string employeeName = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_name").ToString();
            string employeePhone = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_phone").ToString();
            string employeeEmail = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_email").ToString();
            string employeeGender = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_gender").ToString();
            string employeeUserName = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_username").ToString();
            string employeePassword = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Employee_password").ToString();

            if (employeeGender == "True")
            {
                rdNam.Checked = true;
            }
            else
                rdNu.Checked = true;   

            txtEmployeeName.Text = employeeName;
            txtEmployeePhone.Text = employeePhone;
            txtEmployeeEmail.Text = employeeEmail;
            txtEmloyeeUserName.Text = employeeUserName;
            txtEmloyeePassword.Text = employeePassword;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Trim() != "" && txtEmployeePhone.Text.Trim() != "" && txtEmployeeEmail.Text.Trim() != "")
            {
                string employeeName = txtEmployeeName.Text;
                string employeePhone = txtEmployeePhone.Text;
                string employeeEmail = txtEmployeeEmail.Text;
                bool employeeGender = false;
                if (rdNam.Checked)
                    employeeGender = true;

                string employeeUserName = txtEmloyeeUserName.Text;
                string employeePassword = txtEmloyeePassword.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busEmployee.addEmployee(new DTO_Employee(employeeName, employeeGender, employeePhone, employeeEmail, employeeUserName, employeePassword)))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Trim() != "" && txtEmployeePhone.Text.Trim() != "" && txtEmployeeEmail.Text.Trim() != "")
            {
                int employeeId = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Employee_id").ToString());
                string employeeName = txtEmployeeName.Text;
                string employeePhone = txtEmployeePhone.Text;
                string employeeEmail = txtEmployeeEmail.Text;
                bool employeeGender = false;
                if (rdNam.Checked)
                    employeeGender = true;

                string employeeUserName = txtEmloyeeUserName.Text;
                string employeePassword = txtEmloyeePassword.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busEmployee.updateEmployee(new DTO_Employee(employeeId, employeeName, employeeGender, employeePhone, employeeEmail, employeeUserName, employeePassword)))
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
      
            int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Employee_id").ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (busEmployee.deleteEmployee(id))
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}