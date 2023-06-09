using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Employee
    {
        private int _Employee_id;
        private string _Employee_name;
        private bool _Employee_gender;
        private string _Employee_phone;
        private string _Employee_email;
        private string _Employee_username;
        private string _Employee_password;

        public DTO_Employee() { }
        public DTO_Employee(int id) { }

        public DTO_Employee(int employee_id, string employee_name, bool employee_gender, string employee_phone, string employee_email, string employee_username, string employee_password) 
        {
            this._Employee_id = employee_id;
            this._Employee_gender = employee_gender;
            this._Employee_name = employee_name;
            this._Employee_phone = employee_phone;
            this._Employee_email = employee_email;
            this._Employee_username= employee_username;
            this._Employee_password = employee_password;
        }

        public DTO_Employee(string employee_name, bool employee_gender, string employee_phone, string employee_email, string employee_username, string employee_password)
        {
            _Employee_name = employee_name;
            _Employee_gender = employee_gender;
            _Employee_phone = employee_phone;
            _Employee_email = employee_email;
            _Employee_username = employee_username;
            _Employee_password = employee_password;
        }

        public int Employee_id 
        {
            get { return this._Employee_id; } 
            set { this._Employee_id = value;}
        }
        public bool Employee_gender 
        {
            get { return this._Employee_gender; } 
            set { this._Employee_gender = value;}
        }
        public string Employee_name 
        {
            get { return this._Employee_name; }
            set { this._Employee_name = value;}
        }

        public string Employee_phone 
        {
            get { return this._Employee_phone; }
            set { this._Employee_phone = value;}
        }

        public string Employee_email 
        {
            get { return this._Employee_email; }
            set { this._Employee_email = value;}
        }

        public string Employee_username 
        {
            get { return this._Employee_username;}
            set { this._Employee_username = value; }
        }

        public string Employee_password 
        {
            get { return this._Employee_password; }
            set { this._Employee_password = value;}
        }
    }
}
