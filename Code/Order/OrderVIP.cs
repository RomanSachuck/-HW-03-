using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class OrderVIP : Order<HomeDelivery>
    {
        private static Product gift1 = new Product("БМВ Х7м", 111, 1);
        private static Product gift2 = new Product("Мерседес Е300", 1311, 1);
        private static Product gift3 = new Product("Апельсин", 432532, 5);
        public OrderVIP(string description, int number, HomeDelivery delivery, params Product[] products) 
            : base(description, number, delivery, AddGift(products))
        {
        }

        private static Product[] AddGift(Product[] product)
        {
            Product[] result = new Product[product.Length + 1];
            Random rnd = new Random();
            int giftNumber = rnd.Next(3);

            for (int i = 0; i < product.Length; i++)
                result[i] = product[i];

            switch (giftNumber)
            {
                case 0:
                    result[result.Length - 1] = gift1;
                    break;
                case 1:
                    result[result.Length - 1] = gift2;
                    break;
                case 2:
                    result[result.Length - 1] = gift3;
                    break;
                default:
                    break;
            }
            
            return result;
        }
    }
}
