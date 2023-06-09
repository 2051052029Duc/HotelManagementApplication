using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class OrderBUS
    {
        OrderDAL dalOrder = new OrderDAL();
        public int addOrder(DTO_Order order)
        {
            return dalOrder.addOrder(order);
        }

        public DTO_Order getOrderById(int id)
        {
            return dalOrder.getOrderById(id);
        }

        public List<DTO_Order> getOrders(DateTime frm, DateTime to) 
        { 
            return dalOrder.getOrders(frm, to);
        }
        public List<DTO_Order> getPaidOrders(DateTime frm, DateTime to)
        {
            return dalOrder.getPaidOrders(frm, to);

        }
        public bool updateOrder(DTO_Order o)
        {
            return dalOrder.updateOrder(o);
        }
        
    }
}
