﻿using Pattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : EntityBase
    {
        void Add(T entity);
        void Delete(string id);
        void SaveChanges();
        
    }
}
