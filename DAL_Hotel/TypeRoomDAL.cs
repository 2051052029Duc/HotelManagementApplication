using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;


namespace DAL_Hotel
{
    public class TypeRoomDAL
    {
        public static DTO_TypeRoom toTypeRoomDTOMap(TypeRoom t)
        {
            return new DTO_TypeRoom(t.id, t.name, (float)t.price, (int)t.maxCus, (float)t.surCharge, (int)t.qtyBed);
        }

        public List<DTO_TypeRoom> getTypeRoom()
        {
            List<DTO_TypeRoom> list = new List<DTO_TypeRoom>();
            using (var db = new HotelDB())
            {
                var tr = from typeroom in db.TypeRooms select typeroom;
                foreach (var r in tr) 
                {
                    DTO_TypeRoom typeroom = new DTO_TypeRoom();
                    typeroom.TypeRoom_id = r.id;
                    typeroom.TypeRoom_name = r.name;
                    typeroom.TypeRoom_price = (float)r.price;
                    typeroom.TypeRoom_maxCus = (int)r.maxCus;
                    typeroom.TypeRoom_surCharge = (float)r.surCharge;
                    typeroom.TypeRoom_qtyBed = (int)r.qtyBed;
                    list.Add(typeroom);
                }
            }
            return list;
        }
        public string getNameTypeRoomByID(int id)
        {
            try
            {
                HotelDB db = new HotelDB();
                var typeroomName = db.TypeRooms.FirstOrDefault(i => i.id == id);
                return typeroomName.name;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int getTypeRoomIDByName(string name)
        {
            try
            {
                HotelDB db = new HotelDB();
                var typeroomID = db.TypeRooms.FirstOrDefault(i => i.name == name);
                return typeroomID.id;
            }
            catch
            {
                return 0;
            }
        }

        public DTO_TypeRoom getTypeRoomById(int id)
        {
            try
            {
                HotelDB db = new HotelDB();
                var typeRoom = db.TypeRooms.FirstOrDefault(t => t.id == id);
                return TypeRoomDAL.toTypeRoomDTOMap(typeRoom);
            }
            catch
            {
                return new DTO_TypeRoom();
            }
        }

        public bool addTypeRoom(DTO_TypeRoom tr)
        {
            try
            {
                TypeRoom t = new TypeRoom();
                t.id = tr.TypeRoom_id;
                t.name = tr.TypeRoom_name;
                t.price = tr.TypeRoom_price;
                t.maxCus = tr.TypeRoom_maxCus;
                t.surCharge = tr.TypeRoom_surCharge;
                t.qtyBed = tr.TypeRoom_qtyBed;
                HotelDB context = new HotelDB();
                context.TypeRooms.Add(t);
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
            
        }

        public bool updateTypeRoom(DTO_TypeRoom tr, int id)
        {
            try
            {              
                HotelDB context = new HotelDB();               
                var typeroom = context.TypeRooms.FirstOrDefault(t => t.id == id);
                typeroom.name = tr.TypeRoom_name;
                typeroom.price = tr.TypeRoom_price;
                typeroom.maxCus = tr.TypeRoom_maxCus;
                typeroom.surCharge = tr.TypeRoom_surCharge;
                typeroom.qtyBed = tr.TypeRoom_qtyBed;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool deleteTypeRoom(int id)
        {
            try
            {

                HotelDB context = new HotelDB();
                var typeroom = context.TypeRooms.FirstOrDefault(t => t.id == id);
                context.TypeRooms.Remove(typeroom);
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
