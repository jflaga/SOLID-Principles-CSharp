using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0_LSP_violation.Domain
{
    internal interface IBaseGenericRepository<T>
    {
        void Delete(Guid id);
        T FindBy(Guid id);
        T FindBy(int id);
    }
}
