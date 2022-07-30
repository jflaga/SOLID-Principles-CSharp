using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._DIP.Domain.Entities
{
    internal class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Item>? Items { get; set; }
    }
}
