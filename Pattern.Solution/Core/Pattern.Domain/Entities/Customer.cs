using Pattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Domain.Entities
{
    public class Customer: EntityBase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
