using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class HomeDelivery : Delivery
    {
        public string PhoneNumber {  get; private set; }
        public HomeDelivery(string adress, string phoneNumber) : base(adress) 
        {
            PhoneNumber = phoneNumber;
        }

        public override void Run(Delivery delivery, Product[] products)
        {
            Product[] productsInStock = ParseTheOrder(products);
            CourierCompany.Send(productsInStock, (HomeDelivery)delivery);
            Database.Add(delivery);
        }
    }
}
