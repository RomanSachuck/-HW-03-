using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class CompanyCars
    {
        public static void Send(Product[] products, PickPointDelivery delivery)
        {
            Console.Write($"Заказ отправлен автомобилем компании!\n" +
                $"Доставка будет осуществлена в пункт выдачи, расположенный по адресу: {delivery.AddressPickUpPoint}\n" +
                $"Заказчик будет уведомлен о доставке, отправкой письма по адресу проживания: {delivery.Address}\n" +
                $"--------------------------------------------------------------------------------------------------\n\n\n");
        }
        public static void Send(Product[] products, ShopDelivery delivery)
        {
            Console.Write($"Заказ отправлен автомобилем компании!\n" +
                $"Доставка будет осуществлена в магазин, расположенный по адресу проживания: {delivery.AddresShop}\n" +
                $"Заказчик будет уведомлен о доставке, отправкой письма по адресу: {delivery.Address}\n" +
                $"--------------------------------------------------------------------------------------------------\n\n\n");
        }
    }
}
