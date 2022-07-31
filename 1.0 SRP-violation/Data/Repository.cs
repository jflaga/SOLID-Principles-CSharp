using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_SRP_violation.Data
{
    internal class Repository
    {
        public IEnumerable<Datum> GetData()
        {
            return new List<Datum>()
            {
                new Datum() {Name = "Data One", Value = 1.1m, Fee = 0.2m},
                new Datum() {Name = "Data Two", Value = -3.4m, Fee = 0.2m},
                new Datum() {Name = "Data Three", Value = 230m, Fee = 0.2m},
                new Datum() {Name = "Data Four", Value = 29.01m, Fee = 0.2m},
                new Datum() {Name = "Data Five", Value = -47.8m, Fee = 0.2m},
                new Datum() {Name = "Data Six", Value = 123.4m, Fee = 0.2m},
                new Datum() {Name = "Data Seven", Value = 0.1m, Fee = 0.2m},
            };
        }
    }
}
