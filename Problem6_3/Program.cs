using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Problem6_3
{

    public class Products
    {
        public int productId { get; set; }
        public string brandName { get; set; }
        public string description { get; set; }
        public float price { get; set; }
    }
    class Product
    {
        static void Main(string[] args)
        {
            List<Products> product = new List<Products>() {
            new Products() { productId = 200, brandName = "Dell", description = "15 inch Monitor", price = 3400.44f },
            new Products() { productId = 120, brandName = "Dell", description = "Laptop", price = 45000.00f },
           new Products() { productId = 150, brandName = "Microsoft", description = "Windows 7", price = 7000.50f },
           new Products() { productId = 100, brandName = "Logitech", description = "Opetical Mouse", price = 540.00f },
            };
            Console.WriteLine("Product ID\t Brand Name\t\tDescription\t\t\t Price");
            foreach (Products prod in product)
                Console.WriteLine(prod.productId + "\t\t " + prod.brandName + "\t\t\t"+ prod.description+ "\t\t\t    "+prod.price);
            Console.ReadLine();
            OrderById(product, 4);


            foreach (Products prod in product)
                Console.WriteLine(prod.productId + "\t\t " + prod.brandName + "\t\t\t" + prod.description + "\t\t\t    " + prod.price);
            Console.ReadLine();
        }
        static void OrderById(List<Products> lst, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (lst[i].productId >lst[j].productId)
                    {
                        var temp = lst[i];
                        lst[i] = lst[j];
                        lst[j ] = temp;
                    }
                }
            }
            
        }
    }


}
        
    

