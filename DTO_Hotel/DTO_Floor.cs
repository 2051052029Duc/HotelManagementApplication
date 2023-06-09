using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Floor
    {
        private int _Floor_id;
        private string _Floor_name;
        
        public DTO_Floor() { }
        public DTO_Floor(string floor_name)
        {
            _Floor_name = floor_name;
        }

        public DTO_Floor(int id, string floor_name)
        {
            _Floor_id = id;
            _Floor_name = floor_name;
        }

        public int Floor_id
        {
            get { return _Floor_id; }
            set { _Floor_id = value; }
        }

        public string Floor_name
        {
            get { return _Floor_name; } 
            set { _Floor_name = value; }
        }
        
        
        public override string ToString()
        { return _Floor_name; }
    }
}
