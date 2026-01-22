using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCityPOS
{
    public class OrderLine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string unitPrice { get; set; }
        public string totalPrice { get; set; }
    }
}
