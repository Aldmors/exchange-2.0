using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExchangeServer.Data;
using ExchangeServer.Models;

namespace ExchangeServer.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly ExchangeServer.Data.ExchangeServerContext _context;

        public CreateModel(ExchangeServer.Data.ExchangeServerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShipmentId"] = new SelectList(_context.Set<Shipment>(), "ShipmentId", "ShipmentId");
            return Page();
        }

        [BindProperty]
        public Document Document { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Document.Add(Document);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
