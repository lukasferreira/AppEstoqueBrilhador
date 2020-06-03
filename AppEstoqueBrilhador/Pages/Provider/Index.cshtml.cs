﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppDAL;
using AppDomain;

namespace AppEstoqueBrilhador.Pages.Provider
{
    public class IndexModel : PageModel
    {
        private readonly AppDAL.Context _context;

        public IndexModel(AppDAL.Context context)
        {
            _context = context;
        }

        public IList<ProviderX> ProviderX { get;set; }

        public async Task OnGetAsync()
        {
            ProviderX = await _context.Providers.ToListAsync();
        }
    }
}
