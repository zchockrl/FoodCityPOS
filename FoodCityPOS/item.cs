using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCityPOS
{
    class Item
    {
        public string id { get; set; }

        public string name { get; set; }

        public bool perLb { get; set; }

        public double price { get; set; }

        public bool isAlcoholic { get; set; }

        public Item(string ID, string Name, bool PerLb, double Price, bool IsAlcoholic)
        {
            id = ID;
            name = Name;
            perLb = PerLb;
            price = Price; 
            isAlcoholic = IsAlcoholic;
        }
    }
}
