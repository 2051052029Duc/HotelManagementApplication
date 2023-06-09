using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class ProductBUS
    {
        ProductDAL dalProduct = new ProductDAL();

        public List<DTO_Product> getProducts()
        {
            return dalProduct.getProducts();
        }

        public bool addProduct(DTO_Product product)
        {
            return dalProduct.addProduct(product);
        }

        public bool updateProduct(DTO_Product product)
        {
            return dalProduct.updateProduct(product);
        }

        public bool deleteProduct(int id)
        {
            return dalProduct.deleteProduct(id);
        }

        public DTO_Product getProductById(int id)
        {
            return dalProduct.getProductById(id);
        }
    }
}
