using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entites;
using Repository;

namespace Bussiness
{
    internal class CustomerService
    {
        public CustomerRespository CustomerRespository;
        public CartRepoistory cartRepository;
        public CustomerService(
            CustomerRespository customerRepository,
            CartRepoistory cartRepository
            )
        {
            CustomerRespository = customerRepository;
            this.cartRepository = cartRepository;
        }
        public void Registration(string name,string pass)
        {
            Customer customer = new Customer()
            {
                name = name,
                passward = pass
            };

        }
    }
}
