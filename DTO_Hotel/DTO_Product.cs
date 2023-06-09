using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Product
    {
        private int _Product_id;
        private string _Product_name;
        private float _Product_price;

        public DTO_Product()
        {

        }

        public DTO_Product(int product_id, string product_name, float product_price)
        {
            this._Product_id = product_id;
            this._Product_name = product_name;
            this._Product_price = product_price;
        }

        public DTO_Product(string product_name, float product_price)
        {
            this._Product_name = product_name;
            this._Product_price = product_price;
        }

        public int Product_id
        {
            get { return _Product_id; }
            set { _Product_id = value; }
        }

        public string Product_name
        {
            get { return _Product_name; }
            set { _Product_name = value; }
        }

        public float Product_price
        {
            get { return _Product_price; }
            set { _Product_price = value; }
        }
    }
}
