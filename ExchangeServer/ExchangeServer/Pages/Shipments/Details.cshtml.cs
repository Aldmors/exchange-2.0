using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExchangeServer.Data;
using ExchangeServer.Models;

namespace ExchangeServer.Pages.Shipments
{
    public class DetailsModel : PageModel
    {
        private readonly ExchangeServer.Data.ExchangeServerContext _context;

        public DetailsModel(ExchangeServer.Data.ExchangeServerContext context)
        {
            _context = context;
        }

        public Shipment Shipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = await _context.Shipment.FirstOrDefaultAsync(m => m.ShipmentId == id);
            if (shipment == null)
            {
                return NotFound();
            }
            else
            {
                Shipment = shipment;
            }
            return Page();
        }
    }
}
