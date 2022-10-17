using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WatchCollectionApplication.Models;

namespace WatchCollectionApplication.Data
{
    public class WatchCollectionApplicationContext : DbContext
    {
        public WatchCollectionApplicationContext (DbContextOptions<WatchCollectionApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<WatchCollectionApplication.Models.Watch> Watch { get; set; }
    }
}
