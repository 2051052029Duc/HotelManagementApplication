using DTO_Hotel;
using System;
using System.Linq;

namespace DAL_Hotel
{
    public class LoginDAL
    {
        public bool login(string username, string password)
        {
            HotelDB context = new HotelDB();
            if (context.Staffs.FirstOrDefault(em => em.username == username && em.passwords == password) != null)
            {
                return true;
            }
            return false;
        }

        public DTO_Employee getUser(string username, string password)
        {
            HotelDB context = new HotelDB();
            var employee = context.Staffs.FirstOrDefault(em => em.username == username && em.passwords == password);
            DTO_Employee e = new DTO_Employee();
            e.Employee_id = employee.id;
            e.Employee_name = employee.name;
            e.Employee_gender = (bool)employee.gender;
            e.Employee_phone = employee.phone;
            e.Employee_email = employee.email;
            e.Employee_username = employee.username;
            e.Employee_password = employee.passwords;
            return e;
        }
    }
}
