using Pattern.Application.Repositories.CustomerRepositories;
using Pattern.Domain.Entities;
using Pattern.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Persistence.Repositories.CustomerRepositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(PatternDbContext context) : base(context)
        {
        }
    }
}
