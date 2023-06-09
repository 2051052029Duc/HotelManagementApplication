using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_CustomOrder
    {

        public int Order_id { get; set; }
        public DateTime Order_checkin_date { get; set; }
        public DateTime Order_checkout_date { get; set; }
        public float Order_total_amount { get; set; }
        public int Order_num_of_cus { get; set; }
        public string Order_name_cus { get; set; }
        public bool Order_status { get; set; }
        public bool Order_is_group { get; set; }
        public string Order_note { get; set; }
        public int Order_customer_id { get; set; }
        public int Order_employee_id { get; set; }
        public string Order_rooms { get; set; }
    }
}
