using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class OrderStatus
    {
        private bool valueStatus;
        private string nameStatus;

        public OrderStatus()
        {

        }
       

        public OrderStatus(bool value, string name)
        {
            this.value = value;
            this.name = name;
        }

        public bool value
        {
            get { return valueStatus; }
            set { valueStatus = value; }
        }

        public string name
        {
            get { return nameStatus; }
            set { nameStatus = value; }
        }

        public static List<OrderStatus> getList()
        {
            List<OrderStatus> list = new List<OrderStatus>();
            OrderStatus[] collection = new OrderStatus[]
            {
                new OrderStatus(false, "Chưa thanh toán"),
                new OrderStatus(true, "Đã thanh toán")
            };
            list.AddRange(collection); 
            return list;
        }
    }
}
