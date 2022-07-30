using _1._SRP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._SRP.Domain
{
    internal class ReportGenerator
    {
        public PrintableData GenerateReportData(Guid orderId)
        {
            // Get data from db
            var orderRepository = new OrderRepository();
            var order = orderRepository.GetOrder(orderId);

            // Convert raw data to printable data
            var printableData = new PrintableData(order.Id);
            printableData.Items = (from item in order.Items
                                  let discountedPrice = item.Price - (item.Price * item.Discount)
                                   select new PrintableItem
                                  {
                                      Name = item.Name,
                                      DiscountedPrice = discountedPrice,
                                      Quantity = item.Quantity,
                                      TotalNetPrice = discountedPrice * item.Quantity
                                   })
                                  .ToList();
            return printableData;
        }

    }
}
