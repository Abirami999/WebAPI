using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ItemValue { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Colour { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Size { get; set; }

    }
}
