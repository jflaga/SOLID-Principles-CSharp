namespace _1._SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            RawData rawData = new RawData(); // Get data from db
            var printableData = GenerateReport(rawData);
            PrintData(printableData);
        }

        static PrintableData GenerateReport(RawData rawData)
        {
            var printableData = new PrintableData();
            // TODO: Generate printable data
            return printableData;
        }

        static void PrintData(PrintableData data)
        {
            // Print data
        }
    }

    class RawData { }

    class PrintableData { }
}