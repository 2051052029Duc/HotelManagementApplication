using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class OrderDAL
    {
        public static DTO_Order toOrderDTOMap(Order o)
        {
            return new DTO_Order(o.id, (DateTime)o.checkinDate, (DateTime)o.checkoutDate, (float)o.totalAmount, (int)o.numOfCus, (bool)o.status, (bool)o.isGroup, o.note, (int)o.customerID, (int)o.staffID);
        }

        public List<DTO_Order> getOrders(DateTime frm, DateTime to)
        {
            List<DTO_Order> listOrder = new List<DTO_Order>();
            using (var db = new HotelDB())
            {
                var order = from o in db.Orders where (o.checkinDate >= frm && o.checkoutDate < to) select o  ;

                foreach( var od in order )
                {
                    DTO_Order o = OrderDAL.toOrderDTOMap(od);
                    listOrder.Add(o);
                }
            }
            return listOrder;
        }

        public List<DTO_Order> getPaidOrders(DateTime frm, DateTime to)
        {
            List<DTO_Order> listOrder = new List<DTO_Order>();
            using (var db = new HotelDB())
            {
                var order = from o in db.Orders where (o.checkinDate >= frm && o.checkoutDate < to) && o.status == true select o;

                foreach (var od in order)
                {
                    DTO_Order o = OrderDAL.toOrderDTOMap(od);
                    listOrder.Add(o);
                }
            }
            return listOrder;
        }

        public DTO_Order getOrderById(int id)
        {
            using (var db = new HotelDB())
            {
                var order = from o in db.Orders where o.id == id select o;
                foreach (var od in order )
                {
                    return OrderDAL.toOrderDTOMap(od);
                }    
            }
            return null;
        }


        public int addOrder(DTO_Order order)
        {
            try
            {
                Order o = new Order();
                o.id = order.Order_id;
                o.checkinDate = order.Order_checkin_date;
                o.checkoutDate = order.Order_checkout_date;
                o.totalAmount = order.Order_total_amount;
                o.numOfCus = order.Order_num_of_cus;
                o.status = order.Order_status;
                o.isGroup = order.Order_is_group;
                o.note = order.Order_note;
                o.customerID = order.Order_customer_id;
                o.staffID = order.Order_employee_id;

                HotelDB context = new HotelDB();
                context.Orders.Add(o);
                context.SaveChanges();
                return o.id;
            }
            catch
            {
                return -1;
            }
        }

        public bool updateOrder(DTO_Order o)
        {
            try
            {
                HotelDB context = new HotelDB();
                var order = context.Orders.FirstOrDefault(ord => ord.id == o.Order_id);
                order.checkinDate = o.Order_checkin_date;
                order.checkoutDate = o.Order_checkout_date;
                order.totalAmount = o.Order_total_amount;
                order.numOfCus = o.Order_num_of_cus;
                order.status = o.Order_status;
                order.isGroup = o.Order_is_group;
                order.note = o.Order_note;
                order.customerID = o.Order_customer_id;
                order.staffID = o.Order_employee_id;
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
