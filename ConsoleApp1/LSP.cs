using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MySystem
    {
        private readonly IPrinter printer;

        public MySystem(IPrinter printer)
        {
            this.printer = printer;
        }

        public void Print(PrintData data, bool toPrinter)
        {
            if (toPrinter)
                printer.Print(data);
            else
                printer.PrintToScreen(data);
        }
        // use printer here
    }


    // Scenario: let's say this interface is a result of years of modifying the codebase, so it is not properly designed
    interface IPrinter
    {
        // Let's say this method was added 10 years ago
        void Print(PrintData data);

        // Let's say this method was added 2 years ago.
        // The programmer created a separate method to obey the single responsibility principle
        void PrintToScreen(PrintData data);
    }

    // Let's say this class was added 10 years ago
    class Printer : IPrinter
    {
        public void Print(PrintData data)
        {
            // print to printer
        }

        public void PrintToScreen(PrintData data)
        {
            throw new NotImplementedException();
        }
    }

    class ScreenPrinter : IPrinter
    {
        public void Print(PrintData data)
        {
            throw new NotImplementedException();
        }

        public void PrintToScreen(PrintData data)
        {
            // print to screen
        }
    }

    class PrintData
    {
        // data to print
    }
}
