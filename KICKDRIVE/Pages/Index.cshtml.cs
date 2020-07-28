using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using KDControl;
using KDSevice;

namespace KICKDRIVE.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Login> repository;
        public IndexModel(IRepository<Login> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Login> Login { get; private set; }

        public IActionResult OnGet()
        {
            try
            {
                Login = repository.GetAll();
                return Page();
            }
            catch (Exception)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}
