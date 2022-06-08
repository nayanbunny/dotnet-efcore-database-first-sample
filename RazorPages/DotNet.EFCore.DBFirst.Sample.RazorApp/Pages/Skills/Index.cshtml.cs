using DotNet.EFCore.DBFirst.Sample.RazorApp.Data;
using DotNet.EFCore.DBFirst.Sample.RazorApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DotNet.EFCore.DBFirst.Sample.RazorApp.Pages.Skills
{
    public class IndexModel : PageModel
    {
        private readonly EFCoreDBFirstDatabaseContext _context;

        public IndexModel(EFCoreDBFirstDatabaseContext context)
        {
            _context = context;
        }

        public IList<Skill> Skill { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Skills != null)
            {
                Skill = await _context.Skills.ToListAsync();
            }
        }
    }
}
