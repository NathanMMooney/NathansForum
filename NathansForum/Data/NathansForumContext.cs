using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NathansForum.Models;

namespace NathansForum.Data
{
    public class NathansForumContext : DbContext
    {
        public NathansForumContext (DbContextOptions<NathansForumContext> options)
            : base(options)
        {
        }

        public DbSet<NathansForum.Models.Comment> Comment { get; set; } = default!;
        public DbSet<NathansForum.Models.Discussion> Discussion { get; set; } = default!;
    }
}
