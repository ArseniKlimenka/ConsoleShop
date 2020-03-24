using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatShop
{
    class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.Discount(user);
            user.RBalance(price);
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен на склад");
        }
    }
}
