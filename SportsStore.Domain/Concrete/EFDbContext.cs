using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public EFDbContext()
            : base("productsConnstring")
        {

        }
    }

    public class dbInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            List<Product> products = new List<Product>() 
            {
                new Product(){Name="Soccer ball",Description="Offical World Cup Ball",Price=19.99m,Catergory="Soccer"},
                new Product(){Name="Gaelic ball",Description="Offical World Cup Ball",Price=19.99m,Catergory="Soccer"}, 
                new Product(){Name="Basket ball",Description="Offical World Cup Ball",Price=19.99m,Catergory="Soccer"}, 
                new Product(){Name="Cue ball",Description="Offical World Cup Ball",Price=19.99m,Catergory="Soccer"}, 
                new Product(){Name="Champions league ball",Description="Offical World Cup Ball",Price=19.99m,Catergory="Soccer"} 
            };

            foreach(Product p in products)
            {
                context.Products.Add(p);
            }

            base.Seed(context);
            
            
        }
    }
}
