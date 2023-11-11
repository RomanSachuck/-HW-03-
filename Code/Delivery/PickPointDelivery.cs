using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PickPointDelivery : Delivery
    {
        public string AddressPickUpPoint {  get; private set; }

        public PickPointDelivery(string addressPickUpPoint, string adress) : base(adress)
        {
            AddressPickUpPoint = addressPickUpPoint;
        }
        public override void Run(Delivery delivery, Product[] products)
        {
            Product[] productsInStock = ParseTheOrder(products);
            CompanyCars.Send(productsInStock, (PickPointDelivery)delivery);
            Database.Add(delivery);
        }
    }
}
