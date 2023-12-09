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
    public class WriteRepository<T> : IWriteRepository<T> where T : EntityBase
    {
        private readonly PatternDbContext _context;

        public WriteRepository(PatternDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public void Add(T entity)
        {
           Table.Add(entity);
        }

        public void Delete(string id)
        {
           var entity = Table.FirstOrDefault(x => x.Id == Guid.Parse(id));

            Table.Remove(entity);
        }

        public void SaveChanges()
        {
           _context.SaveChanges();
          
        }
    }
}
