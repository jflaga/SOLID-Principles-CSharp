using _1._SRP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._SRP.Presentation
{
    internal class ReportPrinter
    {
        public void Print(PrintableData data)
        {
            Console.WriteLine($"Order: {data.OrderNumber}");
            Console.WriteLine($"Items:");
            Console.WriteLine($"Name\t\tPrice\tQty\tTotal");

            if (data.Items != null)
                foreach (var item in data.Items)
                    Console.WriteLine($"{item.Name}\t\t{item.DiscountedPrice}\t{item.Quantity}\t{item.TotalNetPrice}");

            Console.WriteLine($"    \t\t     \t   \t-----");
            Console.WriteLine($"    \t\t     \t   \t{data.GetOverallNetPrice()}");
        }
    }
}
