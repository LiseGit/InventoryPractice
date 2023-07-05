using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryPractice
{
    public class Inventory
    {
        private List<Product> Products { get; set; }

        public Inventory()
        {
            Products = new List<Product>();
        }
        public Inventory(List<Product> products)
        {
            Products = new List<Product>();
            products.ForEach(x=> AddProduct(x));
        }

        public Inventory(Product product)
        {
            Products = new List<Product>();
            AddProduct(product);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(int id)
        {
            Products.RemoveAll(x => x.Id == id);
        }

        public double SumInventory()
        {
            return Products.Sum(x => x.Price * x.Quantity);
        }

    }
}
