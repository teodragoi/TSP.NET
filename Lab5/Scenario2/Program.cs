using System;

namespace Scenario2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EF6RecipesContext())
            {
                var product = new Product
                {
                    SKU = 148,
                    Description = "Some Description",
                    Price = 100,
                    ImageUrl = "SomeUrl"
                };

                context.Products.Add(product);

                context.SaveChanges();
            }

            using (var context = new EF6RecipesContext())
            {
                foreach(var product in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", product.SKU, product.Price, product.Description, product.ImageUrl);
                }
            }
        }
    }
}
