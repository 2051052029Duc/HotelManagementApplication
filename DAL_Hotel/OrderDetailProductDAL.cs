using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_Hotel
{
    public class OrderDetailProductDAL
    {
        public static DTO_OrderDetailProduct toOrderDetailProductDTOMap(OrderDetailProduct odp)
        {
            return new DTO_OrderDetailProduct(odp.id, (int)odp.quantity, (int)odp.roomID, (int)odp.orderID, (int)odp.productID);
        }

        public List<DTO_OrderDetailProduct> getOrderDetailProductsByOrderId(int id)
        {
            List<DTO_OrderDetailProduct> list = new List<DTO_OrderDetailProduct>();
            using (var db = new HotelDB())
            {
                var orderDetailProduct = from odp in db.OrderDetailProducts where odp.orderID == id select odp;
                foreach (var odp in orderDetailProduct)
                {
                    DTO_OrderDetailProduct o = OrderDetailProductDAL.toOrderDetailProductDTOMap(odp);
                    list.Add(o);
                }
            }
            return list;
        }      
        public List<DTO_OrderDetailProduct> getOrderDetailProductsByRoom(int idRoom, int idOdr)
        {
            List<DTO_OrderDetailProduct> list = new List<DTO_OrderDetailProduct>();
            using (var db = new HotelDB())
            {
                var orderDetailProduct = from odp in db.OrderDetailProducts where (odp.roomID == idRoom && odp.orderID == idOdr ) select odp;
                foreach (var odp in orderDetailProduct)
                {
                    DTO_OrderDetailProduct o = OrderDetailProductDAL.toOrderDetailProductDTOMap(odp);
                    list.Add(o);
                }
            }
            return list;
        }
        public bool addOrderDetailProduct(DTO_OrderDetailProduct order_detail_product)
        {
            try
            {
                OrderDetailProduct o = new OrderDetailProduct();
                o.quantity = order_detail_product.Product_quantity;
                o.roomID = order_detail_product.Product_room_id;
                o.orderID = order_detail_product.Product_order_id;
                o.productID = order_detail_product.Product_product_id;

                HotelDB context = new HotelDB();
                context.OrderDetailProducts.Add(o);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateOrderDetailProduct(DTO_OrderDetailProduct order_detail_product)
        {
            try
            {
                HotelDB context = new HotelDB();
                var o = context.OrderDetailProducts.FirstOrDefault(odr => odr.id == order_detail_product.Product_id);

                o.id = order_detail_product.Product_id;
                o.quantity = order_detail_product.Product_quantity;
                o.roomID = order_detail_product.Product_room_id;
                o.orderID = order_detail_product.Product_order_id;
                o.productID = order_detail_product.Product_product_id;

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteOrderDetailProductsByOrderId(int id)
        {
            using (var db = new HotelDB())
            {
                var order = from o in db.OrderDetailProducts where o.orderID == id select o;
                foreach (var o in order)
                {
                    deleteOrderDetailProduct(o.id);
                }
            }
            return true;
        }
        public bool deleteOrderDetailProduct(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var orderProduct = context.OrderDetailProducts.FirstOrDefault(o => o.id == id);
                context.OrderDetailProducts.Remove(orderProduct);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
