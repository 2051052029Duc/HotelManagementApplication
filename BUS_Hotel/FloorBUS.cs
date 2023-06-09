using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class FloorBUS
    {
        FloorDAL dalFloor = new FloorDAL();

        public List<DTO_Floor> getFloor()
        {
            List<DTO_Floor> list = new List<DTO_Floor>();
            list = dalFloor.getFloor();
            return list;
        }

        public string getNameFloorByID(int id)
        {        
            return dalFloor.getNameFloorByID(id);
        }
        public int getFloorIdByName(string name)
        {
            return dalFloor.getFloorIdByName(name);
        }
        public bool addFloor(DTO_Floor f)
        {
            return dalFloor.addFloor(f);
        }
        public bool removeFloor(int id)
        {
            return dalFloor.removeFloor(id);
        }
        public bool updateFloor (DTO_Floor f, int id)
        {
            return dalFloor.updateFloor(f, id);
        }
    }
}
