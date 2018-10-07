using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoryThreads.Models
{
    public class StoryThreadsContext : DbContext
    {
        public StoryThreadsContext (DbContextOptions<StoryThreadsContext> options)
            : base(options)
        {
        }

        public DbSet<StoryThreads.Models.Profile> Profile { get; set; }
    }
}
