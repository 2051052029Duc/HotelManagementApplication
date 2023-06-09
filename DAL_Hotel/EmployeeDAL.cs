using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL_Hotel
{
    public class EmployeeDAL
    {
        public static DTO_Employee toEmployeeDTOMap(Staff s)
        {
            return new DTO_Employee(s.id, s.name, (bool)s.gender, s.phone, s.email, s.username, s.passwords);
        }

        public List<DTO_Employee> getEmployee() 
        {
            List<DTO_Employee> listEmployee = new List<DTO_Employee>();
            using (var db = new HotelDB())
            {
                var employees = from employee in db.Staffs select employee;

                foreach (var employee in employees) 
                {
                    DTO_Employee e = EmployeeDAL.toEmployeeDTOMap(employee);
                    listEmployee.Add(e);
                }
            }
            return listEmployee;
        }

        public bool addEmplyee(DTO_Employee employee)
        {
            try
            {
                Staff e = new Staff();
                e.id = employee.Employee_id;
                e.name = employee.Employee_name;
                e.email = employee.Employee_email;
                e.gender = employee.Employee_gender;
                e.phone = employee.Employee_phone;
                e.username = employee.Employee_username;
                e.passwords = employee.Employee_password;

                HotelDB context = new HotelDB();
                context.Staffs.Add(e);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateEmployee(DTO_Employee employee)
        {
            try
            {
                HotelDB context = new HotelDB();
                var e = context.Staffs.SingleOrDefault(em => em.id == employee.Employee_id);
                e.name = employee.Employee_name;
                e.email = employee.Employee_email;
                e.gender = employee.Employee_gender;
                e.phone = employee.Employee_phone;
                e.username = employee.Employee_username;
                e.passwords = employee.Employee_password;
                context.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool deleteEmployee(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var e = context.Staffs.SingleOrDefault(em => em.id == id);
                context.Staffs.Remove(e);
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
