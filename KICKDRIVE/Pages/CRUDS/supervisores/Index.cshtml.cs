﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.supervisores
{
    public class IndexModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public IndexModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        public IList<SupervisorS> SupervisorS { get;set; }

        public async Task OnGetAsync()
        {
            SupervisorS = await _context.SupervisorS.ToListAsync();
        }
    }
}
