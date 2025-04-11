
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

            Console.WriteLine($"Press 'S' to display on Screen.");
            Console.WriteLine($"Press 'P' to print from Printer.");

            var keyInput = Console.ReadLine();
            var presenterType = PresenterType.Screen;

            if (keyInput?.ToUpper() == "P")
                presenterType = PresenterType.Printer;
            else if (keyInput?.ToUpper() == "S")
                presenterType = PresenterType.Screen;

            IPresenter presenter = reportPresenterFactory.CreatePresenter(presenterType);
            var orderId = Guid.NewGuid();
            presenter.Print(orderId);
        }
    }
}