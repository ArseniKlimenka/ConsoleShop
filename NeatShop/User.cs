using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatShop
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; }

        public User(string name, int age, double balance, double spent)
        {
            Name = name;
            Age = age;
            Balance = balance;
            Spent = spent;
        }

        public void RBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }

    }
}
