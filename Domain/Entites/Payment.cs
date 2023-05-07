
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    internal class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float TotalPrice { get; set; }
    }
}
