using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_OrderDetailRoom
    {
        private int _Room_id;
        private int _Room_day_at;
        private int _Room_room_id;
        private int _Room_order_id;

        public DTO_OrderDetailRoom()
        {
        }

        public DTO_OrderDetailRoom(int room_day_at, int room_room_id, int room_order_id)
        {
            _Room_day_at = room_day_at;
            _Room_room_id = room_room_id;
            _Room_order_id = room_order_id;
        }

        public DTO_OrderDetailRoom(int room_id, int room_day_at, int room_room_id, int room_order_id)
        {
            _Room_id = room_id;
            _Room_day_at = room_day_at;
            _Room_room_id = room_room_id;
            _Room_order_id = room_order_id;
        }

        public int Room_id { get => _Room_id; set => _Room_id = value; }
        public int Room_day_at { get => _Room_day_at; set => _Room_day_at = value; }
        public int Room_room_id { get => _Room_room_id; set => _Room_room_id = value; }
        public int Room_order_id { get => _Room_order_id; set => _Room_order_id = value; }
    }
}
