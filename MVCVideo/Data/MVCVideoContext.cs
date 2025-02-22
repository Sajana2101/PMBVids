using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCVideo.Models;

namespace MVCVideo.Data
{
    public class MVCVideoContext : DbContext
    {
        public MVCVideoContext (DbContextOptions<MVCVideoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCVideo.Models.Movie> Movie { get; set; } = default!;
    }
}
