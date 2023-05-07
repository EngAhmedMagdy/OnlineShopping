using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRespository
    {
        public Context _context;
        public CustomerRespository(Context context)
        {
            _context = context;
        }
        public void add(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }
    }
}
