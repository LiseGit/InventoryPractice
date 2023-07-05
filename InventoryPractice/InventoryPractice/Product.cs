using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryPractice
{
    public class Product
    {
        public int Id { get; init; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, double price, int quantity)
        {
            Id = id;
            Price = price;
            Quantity = quantity;

        }
    }
}
