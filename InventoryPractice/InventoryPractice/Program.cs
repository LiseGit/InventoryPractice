using System;
using System.Collections.Generic;

namespace InventoryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory(
                new List<Product> { 
                    new Product(1, 4.65, 5),
                    new Product(2, 8.05, 12),
                    new Product(3, 0.05, 530)}
                );
            Console.WriteLine(inventory.SumInventory());
            inventory.AddProduct(new Product(4, 1.55, 9));
            Console.WriteLine(inventory.SumInventory());
            inventory.RemoveProduct(2);
            Console.WriteLine(inventory.SumInventory());
        }
    }
}
