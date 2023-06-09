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
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        ProductBUS busProduct = new ProductBUS();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            gcDanhSach.DataSource = busProduct.getProducts();
        }

        void clearTextBox()
        {
            txtProductName.Clear();
            txtProductPrice.Clear();
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string productId = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Product_id").ToString();
            string productName = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Product_name").ToString();
            string productPrice = gvDanhSach.GetRowCellValue(e.FocusedRowHandle, "Product_price").ToString();
            txtProductName.Text = productName;
            txtProductPrice.Text = productPrice;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text.Trim() != "" && txtProductPrice.Text.Trim() != "")
            {
                string productName = txtProductName.Text;
                float productPrice = float.Parse(txtProductPrice.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busProduct.addProduct(new DTO_Product(productName, productPrice)))
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
            if (txtProductName.Text.Trim() != "" && txtProductPrice.Text.Trim() != "")
            {
                int productId = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Product_id").ToString());
                string productName = txtProductName.Text;
                float productPrice = float.Parse(txtProductPrice.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busProduct.updateProduct(new DTO_Product(productId, productName, productPrice)))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Cập nhật thành công!");
                    } else MessageBox.Show("Cập nhật không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() != "" && txtProductPrice.Text.Trim() != "")
            {
                int id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "Product_id").ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (busProduct.deleteProduct(id))
                    {
                        loadData();
                        clearTextBox();
                        MessageBox.Show("Xoá thành công!");
                    }
                    else MessageBox.Show("Xoá không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
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
    }
}