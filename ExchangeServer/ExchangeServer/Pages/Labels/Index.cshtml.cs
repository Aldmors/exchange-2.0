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
    public class IndexModel : PageModel
    {
        private readonly ExchangeServer.Data.ExchangeServerContext _context;

        public IndexModel(ExchangeServer.Data.ExchangeServerContext context)
        {
            _context = context;
        }

        public IList<Label> Label { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Label = await _context.Label.ToListAsync();
        }
    }
}
