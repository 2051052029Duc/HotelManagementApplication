using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Room
    {
        private int _Room_id;
        private string _Room_num;
        private bool _Room_status;
        private int _Room_floor_id;
        private int _Room_type_id;

        public DTO_Room() { }
        public DTO_Room(int id, string num, bool status, int floor_id, int typeroom_id)
        {
            _Room_id = id;
            _Room_num = num;
            _Room_status = status;
            _Room_floor_id = floor_id;
            _Room_type_id = typeroom_id;
        }

        public DTO_Room(string num, bool status, int floor_id, int typeroom_id)
        {
            _Room_num = num;
            _Room_status = status;
            _Room_floor_id = floor_id;
            _Room_type_id = typeroom_id;
        }

        public int Room_id
        {
            get { return _Room_id; }
            set { _Room_id = value; }
        }

        public string Room_num
        {
            get { return _Room_num; }  
            set { _Room_num = value; }
        }

        public bool Room_status
        { 
            get { return _Room_status; }
            set { _Room_status = value; }
        }


        public int Room_floor_id
        {
            get { return _Room_floor_id; }
            set { _Room_floor_id = value;}  
        }

        public int Room_type_id
        {
            get { return _Room_type_id;}
            set { _Room_type_id = value;}
        }
    }
}
