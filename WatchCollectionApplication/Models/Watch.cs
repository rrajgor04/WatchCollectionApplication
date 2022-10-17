using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchCollectionApplication.Models
{
    public class Watch
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string BrandName {get; set; }
        public DateTime ReleaseDate { get; set; }


        public string WatchMaterial { get; set; }
        public string TypeOfWatch { get; set; }
        public string Quality { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Durability { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(0, 5)]
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Rating { get; set; }
    }
}
