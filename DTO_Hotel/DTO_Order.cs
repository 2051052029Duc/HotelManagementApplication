using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Order
    {
        private int _Order_id;
        private DateTime _Order_checkin_date;
        private DateTime _Order_checkout_date;
        private float _Order_total_amount;
        private int _Order_num_of_cus;
        private bool _Order_status;
        private bool _Order_is_group;
        private string _Order_note;
        private int _Order_customer_id;
        private int _Order_employee_id;

        public DTO_Order()
        {
        }

        public DTO_Order(DateTime order_checkin_date, DateTime order_checkout_date, float order_total_amount, int order_num_of_cus, bool order_status, bool order_is_group, string order_note, int order_customer_id, int order_employee_id)
        {
            _Order_checkin_date = order_checkin_date;
            _Order_checkout_date = order_checkout_date;
            _Order_total_amount = order_total_amount;
            _Order_num_of_cus = order_num_of_cus;
            _Order_status = order_status;
            _Order_is_group = order_is_group;
            _Order_note = order_note;
            _Order_customer_id = order_customer_id;
            _Order_employee_id = order_employee_id;
        }

        public DTO_Order(int order_id, DateTime order_checkin_date, DateTime order_checkout_date, float order_total_amount, int order_num_of_cus, bool order_status, bool order_is_group, string order_note, int order_customer_id, int order_employee_id)
        {
            _Order_id = order_id;
            _Order_checkin_date = order_checkin_date;
            _Order_checkout_date = order_checkout_date;
            _Order_total_amount = order_total_amount;
            _Order_num_of_cus = order_num_of_cus;
            _Order_status = order_status;
            _Order_is_group = order_is_group;
            _Order_note = order_note;
            _Order_customer_id = order_customer_id;
            _Order_employee_id = order_employee_id;
        }

        public int Order_id
        {
            get { return _Order_id; }
            set { _Order_id = value; }
        }

        public DateTime Order_checkin_date
        {
            get { return _Order_checkin_date; }
            set { _Order_checkin_date = value; }
        }

        public DateTime Order_checkout_date
        {
            get { return _Order_checkout_date; }
            set { _Order_checkout_date = value; }   
        }

        public float Order_total_amount
        {
            get { return _Order_total_amount; }
            set { _Order_total_amount = value; }
        }

        public int Order_num_of_cus
        {
            get { return _Order_num_of_cus; }
            set { _Order_num_of_cus = value; }
        }

        public bool Order_status
        {
            get { return _Order_status; } 
            set { _Order_status = value; }
        }

        public bool Order_is_group
        {
            get { return _Order_is_group; }
            set { _Order_status = value; }
        }

        public string Order_note
        {
            get { return _Order_note; } 
            set { _Order_note = value; }
        }

        public int Order_customer_id
        {
            get { return _Order_customer_id; }
            set { _Order_customer_id = value; }
        }

        public int Order_employee_id
        {
            get { return _Order_employee_id; }
            set { _Order_employee_id = value; }
        }
    }
}
