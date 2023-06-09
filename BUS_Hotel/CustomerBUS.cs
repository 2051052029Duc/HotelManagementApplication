using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class CustomerBUS
    {
        CustomerDAL dalCustomer = new CustomerDAL();

        public List<DTO_Customer> getCustmer()
        {
            return dalCustomer.getCustomer();
        }

        public bool addCustomer(DTO_Customer customer)
        {
            return dalCustomer.addCustomer(customer);
        }

        public bool updateCustomer(DTO_Customer customer)
        {
            return dalCustomer.updateCustomer(customer);
        }

        public bool deleteCustomer(int id)
        {
            return dalCustomer.deleteCustomer(id);
        }

        public DTO_Customer getCusById(int id)
        {
            return dalCustomer.getCusById(id);
        }

    }
}

    
