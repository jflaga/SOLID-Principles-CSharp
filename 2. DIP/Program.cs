namespace _2._DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructing object graph
            var reportGenerator = new ReportGenerator();
            var printReportController = new PrintReportController(reportGenerator);

            // Doing action triggered by the user
            printReportController.PrintData();
        }
    }

    class ReportGenerator
    {
        public PrintableData GenerateReport()
        {
            var rawData = new RawData(); // Get data from repository
            // TODO: Generate printable data
            return new PrintableData();
        }
    }

    class PrintReportController
    {
        private readonly ReportGenerator reportGenerator;

        public PrintReportController(ReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public void PrintData()
        {
            var printableData = reportGenerator.GenerateReport();
            printDataToScreen(printableData);
        }

        private void printDataToScreen(PrintableData data)
        {
            // TODO: Print data
        }
    }

    class RawData { }

    class PrintableData { }
}