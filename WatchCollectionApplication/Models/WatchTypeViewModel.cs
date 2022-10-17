using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WatchCollectionApplication.Models
{
    public class WatchTypeViewModel
    {
        public List<Watch> Watches { get; set; }
        public SelectList Types { get; set; }
        public string WatchType { get; set; }
        public string SearchString { get; set; }
    }
}