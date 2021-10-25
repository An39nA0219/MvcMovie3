using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie3.Models;

namespace MvcMovie3.Data
{
    public class MvcMovie3Context : DbContext
    {
        public MvcMovie3Context (DbContextOptions<MvcMovie3Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie3.Models.Movie> Movie { get; set; }
    }
}
