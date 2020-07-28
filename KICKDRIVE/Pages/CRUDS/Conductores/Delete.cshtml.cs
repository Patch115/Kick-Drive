using System;
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
    public class DeleteModel : PageModel
    {
        private readonly KDSevice.AppDbContex _context;

        public DeleteModel(KDSevice.AppDbContex context)
        {
            _context = context;
        }

        [BindProperty]
        public KDControl.Conductor Conductor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conductor = await _context.Conductors.FirstOrDefaultAsync(m => m.Id == id);

            if (Conductor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conductor = await _context.Conductors.FindAsync(id);

            if (Conductor != null)
            {
                _context.Conductors.Remove(Conductor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
