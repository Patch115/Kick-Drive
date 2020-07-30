using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;
using KDSevice;

namespace KICKDRIVE.Pages.CRUDS.Supervisor
{
    public class IndexModel : PageModel
    {
        private readonly KDSevice.AppDbContex _context;

        public IndexModel(KDSevice.AppDbContex context)
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
