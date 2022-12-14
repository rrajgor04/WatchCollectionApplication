
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WatchCollectionApplication.Data;
using System;
using System.Linq;


namespace MvcWatchCollectionApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WatchCollectionApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WatchCollectionApplicationContext>>()))
            {
                if (context.Watch.Any())
                {
                    return; //db has been seeded
                }
                context.Watch.AddRange(
                    new WatchCollectionApplication.Models.Watch
                    {
                        BrandName = "Titan",
                        WatchMaterial = "Elastic",
                        TypeOfWatch = "Digital",
                        Quality = "Fair",
                        Durability = 3.5M,
                        Price = 350M,
                        Rating = 3.5M
                    },
                    new WatchCollectionApplication.Models.Watch
                    {
                        BrandName = "Apple",
                        WatchMaterial = "Rubber",
                        TypeOfWatch = "Digital",
                        Quality = "Best",
                        Durability = 5.5M,
                        Price = 450M,
                        Rating = 3.5M
                    },
                    new WatchCollectionApplication.Models.Watch
                    {
                        BrandName = "Rolex",
                        WatchMaterial = "Metal",
                        TypeOfWatch = "Analog",
                        Quality = "Best",
                        Durability = 5.5M,
                        Price = 750M,
                        Rating = 3.5M
                    },
                    new WatchCollectionApplication.Models.Watch
                    {
                        BrandName = "Samsung",
                        WatchMaterial = "Rubber",
                        TypeOfWatch = "Digital",
                        Quality = "Fair",
                        Durability = 2.5M,
                        Price = 250M,
                        Rating = 3.5M
                    },
                     new WatchCollectionApplication.Models.Watch
                     {
                         BrandName = "Thunderbolt",
                         WatchMaterial = "Rubber",
                         TypeOfWatch = "Digital",
                         Quality = "good",
                         Durability = 3M,
                         Price = 250M,
                         Rating = 3.5M
                     },
                      new WatchCollectionApplication.Models.Watch
                      {
                          BrandName = "Timex",
                          WatchMaterial = "steel",
                          TypeOfWatch = "Analog",
                          Quality = "Fair",
                          Durability = 2.5M,
                          Price = 250M,
                          Rating = 3.5M
                      },
                       new WatchCollectionApplication.Models.Watch
                       {
                           BrandName = "Seiko",
                           WatchMaterial = "Rubber",
                           TypeOfWatch = "Digital",
                           Quality = "good",
                           Durability = 2.5M,
                           Price = 450M,
                           Rating = 1.5M
                       },
                        new WatchCollectionApplication.Models.Watch
                        {
                            BrandName = "Orient",
                            WatchMaterial = "drubberr",
                            TypeOfWatch = "Digital",
                            Quality = "Best",
                            Durability = 4.5M,
                            Price = 250M,
                            Rating = 3.5M
                        },
                         new WatchCollectionApplication.Models.Watch
                         {
                             BrandName = "Beast",
                             WatchMaterial = "Rubber",
                             TypeOfWatch = "Digital",
                             Quality = "Fair",
                             Durability = 2.5M,
                             Price = 250M,
                             Rating = 3.5M
                         }


                    ) ;
                context.SaveChanges();

            }
        }
    }
}
