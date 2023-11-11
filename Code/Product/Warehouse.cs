using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Warehouse
    {
        private static List<Product> CurrentWarehouse = new List<Product>();

        public void AddProduct(string name, int article, int quantity)
        {
            if (CheckAvailability(new Product(name, article, quantity), out int index))
                CurrentWarehouse[index] = new Product(name, article, CurrentWarehouse[index].Quantity + quantity);
            else
                CurrentWarehouse.Add(new Product(name, article, quantity));
        }

        public static void ShowAvailableProducts()
        {
            foreach (Product product in CurrentWarehouse)
                Console.WriteLine(product);
        }

        public static bool CheckAvailability(Product product)
        {
            for (int i = 0; i < CurrentWarehouse.Count; i++)
                if (CurrentWarehouse[i] == product)
                {
                    if (CurrentWarehouse[i].Quantity > 0)
                        return true;
                    else
                        return false;
                }
            return false;
        }

        private static bool CheckAvailability(Product product, out int index)
        {
            for (int i = 0; i < CurrentWarehouse.Count; i++)
                if (CurrentWarehouse[i] == product)
                {
                    index = i;
                    return true;
                }
            index = -1;
            return false;
            
        }

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < CurrentWarehouse.Count)
                {
                    return CurrentWarehouse[index];
                }
                else
                {
                    return null;
                }
            }

            internal set
            {
                if (CheckAvailability(value, out int num))
                    CurrentWarehouse[num] = new Product(value.Name, value.Article, CurrentWarehouse[num].Quantity + value.Quantity);
                else
                    CurrentWarehouse.Insert(index, value);
            }
        }
    }
}
