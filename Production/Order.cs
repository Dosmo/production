using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Order
    {
        public int id { get; set; }
        public string type { get; set; }
        public int quantity { get; set; }
        public List<Order> orderlist { get; set; }

        public Order(int InId, string InType, int InQuantity)
        {
            id = InId;
            type = InType;
            quantity = InQuantity;
            orderlist = new List<Order>();
        }

    }
}
