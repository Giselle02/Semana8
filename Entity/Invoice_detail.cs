using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Invoice_detail
    {
        public string detailId { get; set; }
        public int invoiceId { get; set; }
        public string productId { get; set; }
        public string quantity { get; set; }
        public double Price { get; set; }
        public string subTotal { get; set; }
        public int Active { get; set; }
    }
}
