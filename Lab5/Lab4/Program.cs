using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new ModelSelfReference())
            //{
            //    var selfReference = new SelfReference();

            //    context.SelfReferences.Add(selfReference);
            //    context.SaveChanges();
            //}

            //using (var context = new ModelSelfReference())
            //{
            //    foreach(var reference in context.SelfReferences)
            //    {
            //        Console.WriteLine(reference);
            //    }
            //}

            using (var context = new EF6RecipesContext())
            {
                var product = new Product
                {
                    SKU = 149,
                    Description = "Some desc",
                    ImageUrl = "Some url",
                    Price = 150
                };
                context.Products.Add(product);
                context.SaveChanges();
            }

            using (var context = new EF6RecipesContext())
            {
                foreach(var prod in context.Products)
                {
                    Console.WriteLine(prod.SKU);
                }
            }
        }
    }
}
