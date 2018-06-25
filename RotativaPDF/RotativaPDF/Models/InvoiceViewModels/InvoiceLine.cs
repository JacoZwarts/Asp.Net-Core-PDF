using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotativaPDF.Models.InvoiceViewModels
{
    public class InvoiceLine
    {
        public string LineTitle { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public int VatPercent { get; set; }

        public decimal Net
        {
            get
            {
                return UnitPrice * Amount;
            }
        }
        public decimal Total
        {
            get
            {
                return Net * (1 + VatPercent / 100M);
            }
        }
        public decimal Vat
        {
            get
            {
                return Net * (VatPercent / 100M);
            }
        }
    }
}
