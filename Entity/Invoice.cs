using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {
        public int IdInvoice { get; set; }
        public int IdCustomer { get; set; }
        public DateTime date { get; set; }
        public double Total { get; set; }
        public int Active { get; set; }
    }
}
