using _1._SRP.Domain;
using _1._SRP.Presentation;

namespace _1._SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator();
            var printableData = reportGenerator.GenerateReportData(Guid.NewGuid());

            var reportPrinter = new ReportPrinter();
            reportPrinter.Print(printableData);
        }
    }
}