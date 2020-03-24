using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatShop
{
    class Product
    {
        public string Name { get; set; } = "Ale";
        public string Material { get; set; }="Ale";
        public int Size { get; set; } = 54;
        public double Price { get; set; } = 643;

        public Product(string name,string material,int size,double price)
        {
            Name = name;
            Material = material;
            Size = size;
            Price = price;
        }

        public double Discount(User user)
        {
            if(user.Spent < 500)
            {
                return Price;
            }
            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.5;
            
        }

    }
}
