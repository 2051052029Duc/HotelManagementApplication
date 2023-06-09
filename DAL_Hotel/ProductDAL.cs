using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class ProductDAL
    {

        public static DTO_Product toProductDTOMap(Product p)
        {
            return new DTO_Product(p.id, p.name,(float) p.price); 
        }

        public List<DTO_Product> getProducts()
        {
            List<DTO_Product> listProduct = new List<DTO_Product>();
            using (var db = new HotelDB())
            {
                var products = from product in db.Products select product;

                foreach(var product in products)
                {
                    DTO_Product p = ProductDAL.toProductDTOMap(product);
                    listProduct.Add(p);  
                }
            }
            return listProduct;
        }

        public bool addProduct(DTO_Product product)
        {
            try
            {
                Product p = new Product();
                p.id = product.Product_id;
                p.name = product.Product_name;
                p.price = product.Product_price;

                HotelDB context = new HotelDB();
                context.Products.Add(p);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProduct(DTO_Product product)
        {
            try
            {
                HotelDB context = new HotelDB();
                var pro = context.Products.SingleOrDefault(p => p.id == product.Product_id);
                pro.name = product.Product_name;
                pro.price = product.Product_price;
                context.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool deleteProduct(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var pro = context.Products.SingleOrDefault(p => p.id == id);
                context.Products.Remove(pro);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DTO_Product getProductById(int id)
        {
            using (var db = new HotelDB())
            {
                var pro = db.Products.FirstOrDefault(p => p.id == id);
                return new DTO_Product(id, pro.name, (float)pro.price);
            }
        }

    }
}
