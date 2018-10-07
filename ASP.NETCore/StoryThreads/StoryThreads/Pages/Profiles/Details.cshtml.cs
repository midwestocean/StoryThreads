using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoryThreads.Models;

namespace StoryThreads.Pages.Profiles
{
    public class DetailsModel : PageModel
    {
        private readonly StoryThreads.Models.StoryThreadsContext _context;

        public DetailsModel(StoryThreads.Models.StoryThreadsContext context)
        {
            _context = context;
        }

        public Profile Profile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Profile = await _context.Profile.FirstOrDefaultAsync(m => m.ProfileId == id);

            if (Profile == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
