﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.Usuario
{
    public class DetailsModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public DetailsModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        public KDControl.Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (Usuario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
