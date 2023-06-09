using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class OrderDetailRoomDAL
    {

        public static DTO_OrderDetailRoom toOrderDetailRoomDTOMap(OrderDetailRoom room)
        {
            return new DTO_OrderDetailRoom(room.id ,(int)room.dayAt, (int)room.roomID, (int)room.orderID);
        }

        public List<DTO_OrderDetailRoom> getOrderDetailRoomsByOrderId(int id)
        {
            List<DTO_OrderDetailRoom> list = new List<DTO_OrderDetailRoom> ();
            using (var db = new HotelDB())
            {
                var orderDetailRoom = from odr in db.OrderDetailRooms where odr.orderID == id select odr;
                foreach (var odr in orderDetailRoom) 
                {
                    DTO_OrderDetailRoom o = OrderDetailRoomDAL.toOrderDetailRoomDTOMap(odr);
                    list.Add(o);    
                }
            }
            return list;
        }
        public bool addOrderDetailRoom(DTO_OrderDetailRoom od)
        {
            try
            {
                OrderDetailRoom orderDetail = new OrderDetailRoom();
                orderDetail.orderID = od.Room_order_id;
                orderDetail.roomID = od.Room_room_id;
                orderDetail.dayAt = od.Room_day_at;

                HotelDB context = new HotelDB();
                context.OrderDetailRooms.Add(orderDetail);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateOrderDetailRoom(DTO_OrderDetailRoom od)
        {
            try
            {
                HotelDB context = new HotelDB();

                var orderDetail = context.OrderDetailRooms.FirstOrDefault(odr => odr.id == od.Room_id);

                orderDetail.orderID = od.Room_order_id;
                orderDetail.roomID = od.Room_room_id;
                orderDetail.dayAt = od.Room_day_at;

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DTO_OrderDetailRoom getOdrByIdRoom(int idRoom)
        {
            try
            {
                var context = new HotelDB();
                var o = context.OrderDetailRooms.OrderByDescending(r => r.orderID).FirstOrDefault(r => r.roomID == idRoom);
                return OrderDetailRoomDAL.toOrderDetailRoomDTOMap(o);            }
            catch
            {
                return new DTO_OrderDetailRoom();
            }
        }

        public bool deleteOrderDetailRoomsByOrderId(int id)
        {
            using (var db = new HotelDB())
            {
                var order = from o in db.OrderDetailRooms where o.orderID == id select o;
                foreach (var o in order)
                {
                    deleteOrderDetailRoom(o.id);
                }
            }
            return true;
        }
        public bool deleteOrderDetailRoom(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var orderRoom = context.OrderDetailRooms.FirstOrDefault(o => o.id == id);
                context.OrderDetailRooms.Remove(orderRoom);
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
