using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Shopping
{
    public class ShoppingCart
    {
        private List<Items> Item;
        

        public ShoppingCart()
        {
            Item = new List<Items>();
        }

        public void AddItem(string name, long price, string brand, int count, string size)
        {
            Item.Add(new Items(name, price));
            Console.WriteLine($"Added: {name} - {price} to the cart.");
        }

        public long CalculateTotal()
        {
            long total = 0;
            foreach (var item in Item)
            {
                total += item.Price;
            }
            return total;
        }
        public void GetCartDetails()
        {
            Console.WriteLine("Cart Details: ");
            foreach (var  item in Item)
            {
                Console.WriteLine($"Item: {item.Name}, Price: {item.Price}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            cart.AddItem("laptop", 50000);
            cart.AddItem("headphone", 20000);

            cart.GetCartDetails();
            Console.WriteLine($"Total Price: {cart.CalculateTotal()}");
        }
    }
}
