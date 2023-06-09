using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_TypeRoom
    {
        private int _TypeRoom_id;
        private string _TypeRoom_name;
        private float _TypeRoom_price;
        private int _TypeRoom_maxCus;
        private float _TypeRoom_surCharge;
        private int _TypeRoom_qtyBed;

        public DTO_TypeRoom()
        {
        }

        public DTO_TypeRoom (string typeRoomName, float typeRoomPrice, int typeRoomMaxCus, float typeRoomSurCharge, int typeRoomQtyBed)
        {
            _TypeRoom_name = typeRoomName;
            _TypeRoom_price = typeRoomPrice;
            _TypeRoom_maxCus = typeRoomMaxCus;
            _TypeRoom_surCharge = typeRoomSurCharge;
            _TypeRoom_qtyBed = typeRoomQtyBed;
        }
        public DTO_TypeRoom(int id,string typeRoomName, float typeRoomPrice, int typeRoomMaxCus, float typeRoomSurCharge, int typeRoomQtyBed)
        {
            _TypeRoom_id = id;
            _TypeRoom_name = typeRoomName;
            _TypeRoom_price = typeRoomPrice;
            _TypeRoom_maxCus = typeRoomMaxCus;
            _TypeRoom_surCharge = typeRoomSurCharge;
            _TypeRoom_qtyBed = typeRoomQtyBed;
        }


        public int TypeRoom_id
        {
            get { return _TypeRoom_id; }
            set { _TypeRoom_id = value; }
        }

        public string TypeRoom_name
        {
            get { return _TypeRoom_name; }
            set { _TypeRoom_name = value; }
        }
        public float TypeRoom_price
        {
            get { return _TypeRoom_price; }
            set { _TypeRoom_price  = value; }
        }
        public int TypeRoom_maxCus
        {
            get { return _TypeRoom_maxCus; }
            set { _TypeRoom_maxCus = value; }
        }
        public float TypeRoom_surCharge
        {
            get { return _TypeRoom_surCharge; }
            set { _TypeRoom_surCharge = value; }
        }
        public int TypeRoom_qtyBed
        {
            get { return _TypeRoom_qtyBed; }
            set { _TypeRoom_qtyBed = value; }
        }

        public override string ToString()
        {
            return _TypeRoom_name;
        }
    }
}
