using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class RoomBUS
    {
        RoomDAL dalRoom = new RoomDAL();

        public List<DTO_Room> getEmptyRoom()
        {
            List<DTO_Room> list = new List<DTO_Room>();
            list = dalRoom.getEmptyRoom();
            return list;
        }

        public List<DTO_Room> getRoom()
        {
            List<DTO_Room> list = new List<DTO_Room>();
            list = dalRoom.getRoom();
            return list;
        }

        public List<DTO_Room> getRoomByFloor(int floorId)
        {
            List<DTO_Room> list = new List<DTO_Room>();
            RoomDAL listDisplay = new RoomDAL();
            list = listDisplay.getRoomByFloor(floorId);
            return list;
        }

        public bool addRoom(DTO_Room r)
        {
            return dalRoom.addRoom(r);
        }
        public bool updateRoom(DTO_Room r, int id)
        {
            return dalRoom.updateRoom(r, id);
        }
        public bool removeRoom(int id)
        {
            return dalRoom.removeRoom(id);
        }
        public DTO_Room getRoomById(int id)
        {
            return dalRoom.getRoomById(id);
        }
        public bool changeStatusRoomById(int id, bool status)
        {
            return dalRoom.changeStatusRoomById(id, status);
        }
        public List<DTO_Room> getRoomByOrderId(int id)
        {
            return dalRoom.getRoomByOrderId(id);
        }
    }
}
