using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Shopping
{
    public class Items
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public string Brand { get; set; }
        public int Count { get; set; }
        public string Size { get; set; }

        public Items (string name, long price, string brand, int count, string size)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Count = count;
            Size = size;
        }
    }
}
