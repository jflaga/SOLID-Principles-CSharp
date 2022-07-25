namespace _2._1_DIP_with_repository
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructing object graph
            IRepository repository = new Repository();
            var reportGenerator = new ReportGenerator(repository);
            var printReportController = new PrintReportController(reportGenerator);

            // Doing action triggered by the user
            printReportController.PrintData();
        }
    }

    class ReportGenerator
    {
        private readonly IRepository repository;

        public ReportGenerator(IRepository repository)
        {
            this.repository = repository;
        }

        public PrintableData GenerateReport()
        {
            var rawData = repository.GetRawData();
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

    interface IRepository
    {
        RawData GetRawData();
    }

    class Repository : IRepository
    {
        public RawData GetRawData()
        {
            // TODO: Get raw data from db
            return new RawData();
        }
    }

    class RawData { }

    class PrintableData { }
}