using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class ProductCart
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int productQty { get; set; }
        public float productPrice { get; set; }
        public float productTotalAmount { get; set; }
        public int roomId { get; set; }
        public string roomNum { get; set; }

        public override string ToString()
        {
            return productName;
        }

    }
}
