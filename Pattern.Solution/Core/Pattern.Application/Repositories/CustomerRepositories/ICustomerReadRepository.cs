﻿using Pattern.Domain.Common;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application.Repositories.CustomerRepositories
{
    public interface ICustomerReadRepository: IReadRepository<Customer>
    {
    }
}
