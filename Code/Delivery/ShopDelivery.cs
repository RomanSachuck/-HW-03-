using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ShopDelivery : Delivery
    {
        public string AddresShop { get; private set; }

        public ShopDelivery(string addresShop, string adress) : base(adress)
        {
            AddresShop = addresShop;
        }
        public override void Run(Delivery delivery, Product[] products)
        {
            Product[] productsInStock = ParseTheOrder(products);
            CompanyCars.Send(productsInStock, (ShopDelivery)delivery);
            Database.Add(delivery);
        }
    }
}
