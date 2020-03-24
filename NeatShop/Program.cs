using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Customer", 45, 19000, 400);
            Suit suit1 = new Suit("Armani suit", "Cotton", 34, 7000);
            Suit suit2 = new Suit("Tom Ford suit", "Cotton", 40, 9000);
            Shoes sneak1 = new Shoes("Nike shoes", "Leather", 43, 5000, "Running shoes");
            Shoes sneak2 = new Shoes("Addidas shoes", "Leather", 45, 2400, "Jogging shoes");
            Shoes sneak3 = new Shoes("NB shoes", "Leather", 45, 3700, "Cross-fit shoes");


            Product[] products = new Product[]{
                suit1,suit2,sneak1,sneak2,sneak3 };

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user1.Name} ваш баланс {user1.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user1.Balance)
                    {
                        informer.Buy(user1, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }

                Console.ReadKey();

            }
        }
    }
}
