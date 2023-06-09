using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class OrderDetailRoomBUS
    {
        OrderDetailRoomDAL dalOrderDetailRoom = new OrderDetailRoomDAL();

        public List<DTO_OrderDetailRoom> getOrderDetailRoomsByOrderId(int id)
        {
            return dalOrderDetailRoom.getOrderDetailRoomsByOrderId(id);
        }
        public bool addOrderDetailRoom(DTO_OrderDetailRoom od)
        {
            return dalOrderDetailRoom.addOrderDetailRoom(od);
        }
        public bool updateOrderDetailRoom(DTO_OrderDetailRoom od)
        {
            return dalOrderDetailRoom.updateOrderDetailRoom(od);
        }
        public bool deleteOrderDetailRoom(int id)
        {
            return dalOrderDetailRoom.deleteOrderDetailRoom(id);
        }
        public bool deleteOrderDetailRoomsByOrderId(int id)
        {
            return dalOrderDetailRoom.deleteOrderDetailRoomsByOrderId(id);
        }
        public DTO_OrderDetailRoom getOdrByIdRoom(int idRoom)
        {
            return dalOrderDetailRoom.getOdrByIdRoom(idRoom);
        }
    }
}
