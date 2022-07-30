using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._SRP.Data
{
    internal class OrderDbModel
    {
        public Guid Id { get; set; }
        public IEnumerable<ItemDbModel>? Items { get; set; }
    }
}
