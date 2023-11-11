using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCounter = 0;
            Warehouse warehouse = new Warehouse();

            warehouse[0] = new Product("BMW Х7м", 111, 5);      
            warehouse[1] = new Product("Стиральная машина", 23414, 9); 
            warehouse[2] = new Product("Электробритва", 4432, 2);
            warehouse[3] = new Product("Мерседес Е300", 1311, 5);
            warehouse.AddProduct("Апельсин", 432532, 500);
            warehouse.AddProduct("Посудомоечная машина", 4387, 18);
            warehouse.AddProduct("Сковорода", 430, 6);
            warehouse.AddProduct("Кондиционер", 897, 55);
            warehouse.AddProduct("Сотовый телефон", 45, 12);

            Order<PickPointDelivery> Order1 = new Order<PickPointDelivery>("Первый заказ в магазине", ++orderCounter, new PickPointDelivery("Коммунистическая 74", "Красная 97"),
                new Product("Вентилятор", 423, 1), new Product("Сковорода", 430, 2), new Product("Стиральная машина", 23414, 1), new Product("Газонокосилка", 12, 1));

            OrderVIP orderVIP1 = new OrderVIP("Заказ VIP клиента", ++orderCounter, new HomeDelivery("Университетский проспект 14", "85189946312"),
                new Product("Микроволновка", 32445, 1), new Product("Сотовый телефон", 45, 1), new Product("Кондиционер", 897, 2));

            Order<ShopDelivery> Order2 = new Order<ShopDelivery>("Третий заказ в магазине", ++orderCounter, new ShopDelivery("Красногвардейская 34", "Победы 18"),
                new Product("Глобус", 42323, 1), new Product("Электробритва", 4432, 2), new Product("Стиральная машина", 23414, 1), new Product("Посудомоечная машина", 4387, 18));

            Console.WriteLine("История доставок на дом:");
            Order<HomeDelivery>.DisplayOrderHistory();
            Console.WriteLine("История доставок в пункты выдачи:");
            Order<PickPointDelivery>.DisplayOrderHistory();
            Console.WriteLine("История доставок в магазины:");
            Order<ShopDelivery>.DisplayOrderHistory();
            Console.WriteLine();

            Console.WriteLine("База адресов наших покупателей:");
            Database.ShowData();
        }
    }
}
