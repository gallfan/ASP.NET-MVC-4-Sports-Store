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

    public class dbInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            List<Product> products = new List<Product>() 
            {
                new Product(){Name="Soccer ball",Description="Offical World Cup Ball",Price=19.99m,Category="Soccer"},
                new Product(){Name="Lifejacket",Description="Protective and fashionable",Price=35.99m,Category="Watersports"}, 
                new Product(){Name="Kayak",Description="Boat for one person",Price=275.00m,Category="Watersports"}, 
                new Product(){Name="Cue ball",Description="Offical World Cup Ball",Price=19.99m,Category="Watersports"}, 
                new Product(){Name="Soccer hat",Description="Offical World Cup Ball",Price=19.99m,Category="Soccer"}, 
                new Product(){Name="Corner flags",Description="Offical World Cup Ball",Price=19.99m,Category="Soccer"}, 
                new Product(){Name="Board game",Description="Offical World Cup Ball",Price=19.99m,Category="Soccer"}, 
                new Product(){Name="Cones",Description="Offical World Cup Ball",Price=19.99m,Category="Chess"}, 
                new Product(){Name="Gloves",Description="Offical World Cup Ball",Price=19.99m,Category="Chess"}, 
                new Product(){Name="Whistles",Description="Offical World Cup Ball",Price=19.99m,Category="Chess"}, 
                new Product(){Name="Liverpool Jersey",Description="Offical World Cup Ball",Price=19.99m,Category="Chess"},
                new Product(){Name="Football boots",Description="Offical World Cup Ball",Price=19.99m,Category="Chess"} 
            };

            foreach(Product p in products)
            {
                context.Products.Add(p);
            }

            base.Seed(context);
            
            
        }
    }
}
