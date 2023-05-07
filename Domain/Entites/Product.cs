using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public  class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Quantity {get;set;}
        public int price { get; set; }

    }
}
