using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{

    public class OrderDetailProductBUS
    {
        OrderDetailProductDAL dalOrderDetailProduct = new OrderDetailProductDAL();

        public List<DTO_OrderDetailProduct> getOrderDetailProductsByOrderId(int id)
        {
            return dalOrderDetailProduct.getOrderDetailProductsByOrderId(id);
        }
        public List<DTO_OrderDetailProduct> getOrderDetailProductsByRoom(int idRoom, int idOdr)
        {
            return dalOrderDetailProduct.getOrderDetailProductsByRoom(idRoom, idOdr);
        }

        public bool addOrderDetailProduct(DTO_OrderDetailProduct order_detail_product)
        {
            return dalOrderDetailProduct.addOrderDetailProduct(order_detail_product);
        }

        public bool updateOrderDetailProduct(DTO_OrderDetailProduct order_detail_product)
        {
            return dalOrderDetailProduct.updateOrderDetailProduct(order_detail_product);
        }
        public bool deleteOrderDetailProductsByOrderId(int id)
        {
            return dalOrderDetailProduct.deleteOrderDetailProductsByOrderId(id);
        }
        public bool deleteOrderDetailProduct(int id)
        {
            return dalOrderDetailProduct.deleteOrderDetailProduct(id);

        }
    }
}
