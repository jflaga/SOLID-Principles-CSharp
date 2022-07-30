using _2._DIP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._DIP.Domain
{
    internal interface IOrderRepository
    {
        Order GetOrder(Guid orderId);
    }
}
