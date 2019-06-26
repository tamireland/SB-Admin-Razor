using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SB_Admin_Razor.Models;

namespace SB_Admin_Razor.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly SB_Admin_Razor.Models.DatabaseContext _context;

        public IndexModel(SB_Admin_Razor.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
