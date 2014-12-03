using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Product
    {
        public string process { get; set; }
        public double time { get; set; }
        public List<Product> productInfo { get; set; }
        public List<Product> orderLine { get; set; }

        public Product(string InProcess, double InTime)
        {
            process = InProcess;
            time = InTime;
            productInfo = new List<Product>();
            orderLine = new List<Product>();

        } 
    }
}
