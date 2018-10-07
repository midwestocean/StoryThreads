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
    public class IndexModel : PageModel
    {
        private readonly StoryThreads.Models.StoryThreadsContext _context;

        public IndexModel(StoryThreads.Models.StoryThreadsContext context)
        {
            _context = context;
        }

        public IList<Profile> Profile { get;set; }

        public async Task OnGetAsync()
        {
            Profile = await _context.Profile.ToListAsync();
        }
    }
}
