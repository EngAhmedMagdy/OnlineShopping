using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    internal class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int count { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
