
using Microsoft.EntityFrameworkCore;
using WatchCollectionApplication.Models;

namespace WatchCollectionApplication.Data
{
    public class MvcWatchContext : DbContext
    {
        public MvcWatchContext (DbContextOptions<MvcWatchContext> options) : base(options)
        {

        }
        public DbSet<Watch>Watch { get; set; }
    }
}
