using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCityPOS
{
    class POSSession
    {
        public static string currentUser { get; set; }
        public static bool valuCardApplied { get; set; }

        public static List<Item> delayedVoids = new List<Item>();

        public static Item lastItem { get; set; }

        public static string customerFirstName { get; set; }
        public static string customerLastName { get; set; }

        public double subtotal { get; set; }

        public double tax { get; set; }

        public double total { get; set; }

        public double tendered { get; set; }
    }
}
