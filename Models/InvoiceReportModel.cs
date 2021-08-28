using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3.Models
{
    class InvoiceReportModel
    {
        public DateTime DeliveryDate { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Subtotal { get; set; }
    }
}
