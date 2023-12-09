using Microsoft.EntityFrameworkCore;
using Pattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application.Repositories
{
    public interface IRepository<T> where T: EntityBase
    {
        DbSet<T> Table { get; }
    }
}
