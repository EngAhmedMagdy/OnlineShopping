using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CartRepoistory
    {
        public Context _context;
        public CartRepoistory(Context context)
        {
            _context = context;
        }
        public void add(Cart c)
        {
            _context.Carts.Add(c);
            _context.SaveChanges();
        }
    }
}
