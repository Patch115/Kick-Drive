﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;
using KDSevice;

namespace KICKDRIVE.Pages.CRUDS.Conductores
{
    public class IndexModel : PageModel
    {
        private readonly KDSevice.AppDbContex _context;

        public IndexModel(KDSevice.AppDbContex context)
        {
            _context = context;
        }

        public IList<Conductor> Conductor { get;set; }

        public async Task OnGetAsync()
        {
            Conductor = await _context.Conductors.ToListAsync();
        }
    }
}