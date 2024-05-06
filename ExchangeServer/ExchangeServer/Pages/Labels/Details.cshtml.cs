﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExchangeServer.Data;
using ExchangeServer.Models;

namespace ExchangeServer.Pages.Labels
{
    public class DetailsModel : PageModel
    {
        private readonly ExchangeServer.Data.ExchangeServerContext _context;

        public DetailsModel(ExchangeServer.Data.ExchangeServerContext context)
        {
            _context = context;
        }

        public Label Label { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var label = await _context.Label.FirstOrDefaultAsync(m => m.LabelId == id);
            if (label == null)
            {
                return NotFound();
            }
            else
            {
                Label = label;
            }
            return Page();
        }
    }
}
