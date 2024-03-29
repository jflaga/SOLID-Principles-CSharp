﻿using _1._SRP.Domain;
using _1._SRP.Presentation;

namespace _1._SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SRP example");
            Console.WriteLine();

            var orderId = Guid.NewGuid();
            var reportGenerator = new ReportGenerator();
            var printableData = reportGenerator.GenerateReportData(orderId);

            var reportPrinter = new ReportPresenter();
            reportPrinter.Present(printableData);
        }
    }
}