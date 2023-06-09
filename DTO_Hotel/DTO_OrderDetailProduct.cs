using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_OrderDetailProduct
    {
        private int _Product_id;
        private int _Product_quantity;
        private int _Product_room_id;
        private int _Product_order_id;
        private int _Product_product_id;

        public DTO_OrderDetailProduct(int product_quantity, int product_room_id, int product_order_id, int product_product_id)
        {
            _Product_quantity = product_quantity;
            _Product_room_id = product_room_id;
            _Product_order_id = product_order_id;
            _Product_product_id = product_product_id;
        }

        public DTO_OrderDetailProduct(int product_id, int product_quantity, int product_room_id, int product_order_id, int product_product_id)
        {
            _Product_id = product_id;
            _Product_quantity = product_quantity;
            _Product_room_id = product_room_id;
            _Product_order_id = product_order_id;
            _Product_product_id = product_product_id;
        }

        public int Product_id
        {
            get { return _Product_id; }
            set { _Product_id = value; }
        }

        public int Product_quantity 
        {
            get { return _Product_quantity; }
            set { _Product_quantity = value; }
        }
        public int Product_room_id 
        {
            get { return _Product_room_id; }
            set { _Product_room_id = value; }
        }
        public int Product_order_id 
        {
            get { return _Product_order_id; }
            set { _Product_order_id = value; }
        }
        public int Product_product_id 
        {
            get { return _Product_product_id; }
            set { _Product_product_id = value; }
        }
    }
}
