using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchCollectionApplication.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string BrandName {get; set; }
        public DateTime ReleaseDate { get; set; }
        public string WatchMaterial { get; set; }
        public string TypeOfWatch { get; set; }
        public string Quality { get; set; }
        public decimal Durability { get; set; }
        public decimal Price { get; set; }
    }
}
