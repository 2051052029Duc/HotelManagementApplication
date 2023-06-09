using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Customer
    {
        private int _Customer_id;
        private string _Customer_name;
        private bool _Customer_gender;
        private string _Customer_phone;
        private string _Customer_address;
        private string _Customer_personalID;

        public DTO_Customer() { }

        public DTO_Customer(string customer_name, bool customer_gender, string customer_phone, string customer_address, string customer_PersonalID)
        {
            _Customer_name = customer_name;
            _Customer_gender = customer_gender;
            _Customer_phone = customer_phone;
            _Customer_address = customer_address;
            _Customer_personalID = customer_PersonalID;
        }

        public DTO_Customer(int customer_id, string customer_name, bool customer_gender, string customer_phone, string customer_address, string customer_PersonalID)
        {
            _Customer_id = customer_id;
            _Customer_name = customer_name;
            _Customer_gender = customer_gender;
            _Customer_phone = customer_phone;
            _Customer_address = customer_address;
            _Customer_personalID = customer_PersonalID;
        }

        public int Customer_id 
        { 
            get => _Customer_id; 
            set => _Customer_id = value; 
        
        }
        public string Customer_name 
        { get => _Customer_name; 
            set => _Customer_name = value; 
        }

        public bool Customer_gender 
        { get => _Customer_gender; 
            set => _Customer_gender = value;
        }

        public string Customer_phone 
        { get => _Customer_phone; 
            set => _Customer_phone = value; 
        
        }

        public string Customer_address 
        { get => _Customer_address; 
            set => _Customer_address = value; 
        
        }

        public string Customer_personalID 
        { 
            get => _Customer_personalID; 
            set => _Customer_personalID = value; 
        }
    }
}
