using Microsoft.EntityFrameworkCore;
using Pattern.Application.Repositories;
using Pattern.Domain.Common;
using Pattern.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly PatternDbContext _context;

        public ReadRepository(PatternDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(string id)
        {
            return Table.FirstOrDefault(x => x.Id == Guid.Parse(id));
        }
    }
}
