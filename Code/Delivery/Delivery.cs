using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Delivery
    {
        public string Address { get; private set; }

        public Delivery(string adress) 
        {
            Address = adress;
        }
        public abstract void Run(Delivery delivery, Product[] products);
        protected Product[] ParseTheOrder(Product[] products)
        {
            List<Product> productsInStock = new List<Product>();
            List<Product> missingProducts = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                if (Warehouse.CheckAvailability(products[i]))
                    productsInStock.Add(products[i]);
                else
                    missingProducts.Add(products[i]);
            }

            if(missingProducts.Count > 0)
            {
                Console.WriteLine("Из заказа были удалены отсутствующие товары: ");
                foreach (Product product in missingProducts)
                    Console.WriteLine(product + " ");
                Console.WriteLine("\n\n");
            }
            return productsInStock.ToArray();
        }
    }
}
