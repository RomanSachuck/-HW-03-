using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class Database
    {
        private static List<string> AddresDeliveryCompleted = new List<string>();

        public static void Add<TDelivery>(TDelivery delivery)
            where TDelivery : Delivery
        {
            AddresDeliveryCompleted.Add(delivery.Address);
        }

        public static void ShowData()
        {
            foreach (var item in AddresDeliveryCompleted)
                Console.WriteLine(item);
        }
    }
}
