﻿using _4._0_LSP_violation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0_LSP_violation.Data
{
    internal class AnotherRepositoryUsingIntForId : IAnotherRepositoryUsingIntForId
    {
        public void Delete(Guid id)
        {
            // delete entity
        }

        public object FindBy(int id)
        {
            object objectFromDb = new object(); // get from db
            return objectFromDb;
        }

        public object FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
