using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class FloorDAL
    {
        public List<DTO_Floor> getFloor()
        {
            List<DTO_Floor> list = new List<DTO_Floor>();
            using (var db = new HotelDB())
            {
                var tb = from floor in db.Floors
                         select floor ;

                foreach (var i in tb)
                {
                    DTO_Floor floor = new DTO_Floor();
                    floor.Floor_id = i.id;
                    floor.Floor_name = i.name;
                    list.Add(floor);
                }
            }

            return list;
        }
        public string getNameFloorByID(int id)
        {
            try
            {
                HotelDB db = new HotelDB();
                var floorName = db.Floors.FirstOrDefault(i => i.id == id);
                return floorName.name;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public int getFloorIdByName(string name)
        {
            try
            {
                HotelDB db = new HotelDB();
                var floorID = db.Floors.FirstOrDefault(i => i.name == name);
                return floorID.id;
            }
            catch
            {
                return 0;
            }
        }

        public bool addFloor(DTO_Floor f)
        {
            try
            {
                Floor floor = new Floor();
                floor.id = f.Floor_id;
                floor.name = f.Floor_name;
                HotelDB context = new HotelDB();
                context.Floors.Add(floor);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateFloor(DTO_Floor f, int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var floor = context.Floors.FirstOrDefault(t => t.id == id);
                floor.name = f.Floor_name;
                context.SaveChanges();
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool removeFloor(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var floor = context.Floors.FirstOrDefault(t => t.id == id);
                context.Floors.Remove(floor);
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
