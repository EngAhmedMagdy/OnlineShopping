using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
        public int TotalPrice {get;set;}
        [ForeignKey("CartItem")]
        public int CartItemId { get; set; }
    }

}
