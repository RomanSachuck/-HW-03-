using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class CourierCompany
    {
        public static void Send(Product[] products, HomeDelivery delivery)
        {
            Console.Write($"Заказ отправлен службой курьерской доставки!\n" +
                $"Доставка будет осуществлена домой заказчику, по адресу: {delivery.Address}\n" +
                $"Заказчик будет уведомлен о доставке, звонком по номеру: {delivery.PhoneNumber}\n" +
                $"--------------------------------------------------------------------------------------------------\n\n\n");
        }
    }
}
