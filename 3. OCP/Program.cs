
using _3._OCP.Data;
using _3._OCP.Domain;
using _3._OCP.Presentation;

namespace _3._OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"OCP example");
            Console.WriteLine();

            // Constructing object graph
            IOrderRepository orderRepository = new OrderRepository();
            var reportGenerator = new ReportGenerator(orderRepository);
            var reportPresenterFactory = new ReportPresenterFactory(reportGenerator);

            // Do work
            // -> If display on screen
            //var presenter = reportPresenterFactory.CreatePresenter(PresenterType.Screen);
            // -> If print to printer
            //var presenter = reportPresenterFactory.CreatePresenter(PresenterType.Printer);

            IPresenter? presenter;
            Console.WriteLine($"Press 'S' to display on Screen.");
            Console.WriteLine($"Press 'P' to print from Printer.");

            var keyInput = Console.ReadLine();
            if (keyInput?.ToUpper() == "P")
                presenter = reportPresenterFactory.CreatePresenter(PresenterType.Printer);
            else
                presenter = reportPresenterFactory.CreatePresenter(PresenterType.Screen);

            var orderId = Guid.NewGuid();
            presenter?.Print(orderId);
        }
    }
}