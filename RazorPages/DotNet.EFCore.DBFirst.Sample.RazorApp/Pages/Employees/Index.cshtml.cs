using DotNet.EFCore.DBFirst.Sample.RazorApp.Data;
using DotNet.EFCore.DBFirst.Sample.RazorApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DotNet.EFCore.DBFirst.Sample.RazorApp.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EFCoreDBFirstDatabaseContext _context;

        public IndexModel(EFCoreDBFirstDatabaseContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees
                .Include(e => e.Department).ToListAsync();
            }
        }
    }
}
