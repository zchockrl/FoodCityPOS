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

        public static List<Item> itemsInOrder = new List<Item>();

        public static List<Item> delayedVoids = new List<Item>();

        public static bool inOrder = false;

        public static Item lastItem { get; set; }

        public static string customerFirstName { get; set; }
        public static string customerLastName { get; set; }

        public static double subtotal { get; set; }

        public static double tax { get; set; }

        public static double total { get; set; }

        public static double tendered { get; set; }

        public static int multiplier = 1;

        public static void addItemToOrder(Item item)
        {
            itemsInOrder.Add(item);
        }
    }
}
