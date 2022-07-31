using _1._0_SRP_violation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_SRP_violation.Presentation
{
    internal class ReportPrinter
    {
        public void Print()
        {
            Console.WriteLine($"SRP violation example");
            Console.WriteLine();

            // Get data from db
            var repository = new Repository();
            var data = repository.GetData();

            Console.WriteLine($"Name\t\tValue\tFee\tNet Value");
            foreach (var datum in data)
            {
                Console.Write($"{datum.Name}\t");
                PrintValueAndFee(datum);
                PrintNetValue(datum);

                Console.WriteLine();
            }
        }

        private static void PrintValueAndFee(Datum datum)
        {
            if (datum.Value < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{datum.Value}\t{datum.Fee}\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{datum.Value}\t{datum.Fee}\t");
            }
        }

        private static void PrintNetValue(Datum datum)
        {
            var netValue = datum.Value - datum.Fee;
            if (netValue < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{datum.Value - datum.Fee}");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{datum.Value - datum.Fee}");
            }
        }
    }
}
