using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatShop
{
    class Shoes : Product
    {
        public string Type { get; set; }

        public Shoes(string name,string material,int size,double price,string type):base(name,material,size,price)
        {
           Type = type;
        }
    }
}
