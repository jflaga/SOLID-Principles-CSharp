using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SRP
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

}
