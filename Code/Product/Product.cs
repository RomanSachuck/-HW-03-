using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Product
    {
        public string Name { get; private set; }
        private int quantity;
        public int Quantity {
            get{ return quantity; }
            private set 
            {
                if (value.IsNegative())
                    throw new ArgumentException();
                else
                    quantity = value;
            }
        }
        private int article;
        public int Article
        {
            get { return article; }
            private set
            {
                if (value.IsNegative())
                    throw new ArgumentException();
                else
                    article = value;
            }
        }

        public Product(string name, int article, int count)
        {
            Name = name;
            Article = article;
            Quantity = count;  
        }

        public static bool operator == (Product a, Product b)
        {
            if(a.Article == b.Article)
                return true;
            else return false;
        }
        public static bool operator != (Product a, Product b)
        {
            if (!(a.Article == b.Article))
                return true;
            else return false;
        }
        public override string ToString()
        {
            return $"{Name} в количестве: {Quantity}";                    
        }
    }
}
