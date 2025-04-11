using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Presentation;
internal class NullPresenter : IPresenter
{
    public void Print(Guid orderId)
    {
        // do nothing
    }
}
