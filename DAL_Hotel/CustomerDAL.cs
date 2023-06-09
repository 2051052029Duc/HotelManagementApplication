using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class CustomerDAL
    {
        public static DTO_Customer toCustomerDTOMap(Customer c)
        {
            return new DTO_Customer(c.id, c.name, (bool)c.gender, c.phone, c.address, c.personalId);
        }

        public List<DTO_Customer> getCustomer()
        {
            List<DTO_Customer> listCustomer = new List<DTO_Customer>();
            using (var db = new HotelDB())
            {
                var customer = from cus in db.Customers select cus;

                foreach (var cus in customer)
                {
                    DTO_Customer c = CustomerDAL.toCustomerDTOMap(cus);
                    listCustomer.Add(c);
                }
            }
            return listCustomer;
        }

        public bool addCustomer(DTO_Customer customer)
        {
            try
            {
                Customer c = new Customer();
                c.id = customer.Customer_id;
                c.name = customer.Customer_name;
                c.gender = customer.Customer_gender;    
                c.phone = customer.Customer_phone;
                c.address = customer.Customer_address;
                c.personalId = customer.Customer_personalID;

                HotelDB context = new HotelDB();
                context.Customers.Add(c);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateCustomer(DTO_Customer customer)
        {
            try
            {
                HotelDB context = new HotelDB();
                var cus = context.Customers.SingleOrDefault(c => c.id == customer.Customer_id);
                cus.name = customer.Customer_name;
                cus.gender = customer.Customer_gender;
                cus.phone = customer.Customer_phone;
                cus.address = customer.Customer_address; ;
                cus.personalId = customer.Customer_personalID;

                context.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool deleteCustomer(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var cus = context.Customers.SingleOrDefault(c => c.id == id);
                context.Customers.Remove(cus);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DTO_Customer getCusById(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var cus = from c in context.Customers where c.id == id select c;
                foreach(var c in cus)
                {
                    DTO_Customer cs = CustomerDAL.toCustomerDTOMap(c);
                    return cs;
                }
            }
            catch
            {

            }
            return new DTO_Customer();

        }
    }
}
