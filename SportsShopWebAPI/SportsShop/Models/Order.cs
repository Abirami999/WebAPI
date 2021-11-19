using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.Models
{
    public class Order
    {
       [Key]
       public int OrderId { get; set; }

       public DateTime OrderDate { get; set; }

       public DateTime DeliveryDate { get; set; }

       public string PaymentMode { get; set; }

       public virtual Customer Customer { get; set; }

       public virtual Item Item { get; set; }
    }
}
