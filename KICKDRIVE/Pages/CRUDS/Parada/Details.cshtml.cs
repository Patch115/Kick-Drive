using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;
using KDSevice;

namespace KICKDRIVE.Pages.CRUDS.Parada
{
    public class DetailsModel : PageModel
    {
        private readonly KDSevice.AppDbContex _context;

        public DetailsModel(KDSevice.AppDbContex context)
        {
            _context = context;
        }

        public KDControl.Parada Parada { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parada = await _context.Paradas.FirstOrDefaultAsync(m => m.Id == id);

            if (Parada == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
