using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using RotativaPDF.Models.InvoiceViewModels;

namespace RotativaPDF.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Invoice()
        {
            return View("Invoice",InvoiceViewModel.GetOne());
        }

        public IActionResult InvoicePdf()
        {
            return new ViewAsPdf("Invoice",InvoiceViewModel.GetOne());
        }
    }
}