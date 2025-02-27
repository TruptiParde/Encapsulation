
using System.ComponentModel;

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
            Item.Add(new Items(name, price, brand, count, size));
            Console.WriteLine($"{count} piece of {size} size of {name} of {brand} with {price} rupees charge, successfully added to the cart");
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
            foreach (var item in Item)
            {
                Console.WriteLine($"Item: {item.Name}, Price: {item.Price}, Brand: {item.Brand}, Count: {item.Count}, Size: {item.Size}");
            }
        }
    }
}
