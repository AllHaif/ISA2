using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity_2.Models;

namespace ContosoUniversity_2.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity_2.Models.SchoolContext _context;

        public IndexModel(ContosoUniversity_2.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
