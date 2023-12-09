using Microsoft.EntityFrameworkCore;
using Pattern.Application.Repositories.ProductRepositories;
using Pattern.Domain.Entities;
using Pattern.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(PatternDbContext context) : base(context)
        {
        }
    }
}
