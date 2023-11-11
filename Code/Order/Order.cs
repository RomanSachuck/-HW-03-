using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Order<TDelivery> 
        where TDelivery : Delivery
    {
        private TDelivery delivery;
        private Product[] products;
        private int number;
        private static Dictionary<int, String> OrderHistory = new Dictionary<int, string>();

        public Order(string description, int number, TDelivery delivery, params Product[] products)
        {
            if(this is OrderVIP)
            {
                Console.WriteLine($"Внимание! заказ номер {number} оформлен со статусом VIP!\n" +
                $"В заказ будет добавлен подарок! {products[products.Length - 1]}");
                Console.WriteLine();
            }

            this.number = number;
            this.delivery = delivery;
            this.products = new Product[products.Length];

            for (int i = 0; i < products.Length; i++)
                this.products[i] = products[i];

            NotifyRegistration();
            this.delivery.Run(this.delivery, this.products);
            OrderHistory.Add(number, description);
        }

        private void NotifyRegistration()
        {
            Console.WriteLine($"Заказ номер {number} принят в обработку!\n" +
                $"В заказ входят:");
            DisplayProducts();
            Console.WriteLine("Адрес заказчика:");
            DisplayAddress();
            Console.WriteLine("\n\n");
        }
        public void DisplayAddress()
        {
            Console.WriteLine(delivery.Address);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
                Console.WriteLine(product);
        }

        public static void DisplayOrderHistory()
        {
            Console.WriteLine("Номер заказа:       Описание заказа:");
            foreach (var order in OrderHistory)
                Console.WriteLine($"       {order.Key}           {order.Value}");
            Console.WriteLine("\n------------------------------------------------");
        }
    }
}
