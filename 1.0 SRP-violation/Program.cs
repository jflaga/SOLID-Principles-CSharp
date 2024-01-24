﻿using _1._SRP_violation.Presentation;

namespace _1._SRP_violation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SRP violation example");
            Console.WriteLine();

            var orderId = Guid.NewGuid();
            var reportPrinter = new ReportPresenter();
            reportPrinter.Present(orderId);
        }
    }
}