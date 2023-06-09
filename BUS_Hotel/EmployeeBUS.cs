using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class EmployeeBUS
    {
        EmployeeDAL dalEmployee = new EmployeeDAL();

        public List<DTO_Employee> getEmployee()
        {
            return dalEmployee.getEmployee();
        }

        public bool addEmployee(DTO_Employee employee)
        {
            return dalEmployee.addEmplyee(employee);
        }

        public bool updateEmployee(DTO_Employee employee)
        {
            return dalEmployee.updateEmployee(employee);
        }

        public bool deleteEmployee(int id)
        {
            return dalEmployee.deleteEmployee(id);
        }
    }
}
